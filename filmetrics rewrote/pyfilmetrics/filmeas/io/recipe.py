"""FILMeasure recipe files (.fitrp / .fitra) — parse, edit, and re-checksum.

Format (see filmetric_re/recipe_schema.md): plain text, CRLF, comma-separated ``Key, Value`` lines,
``[Section]`` headers, and ``===== Measure Site N =====`` blocks; trailer
``***End Machine Readable Structure***`` then ``CHECKSUM= <int>``.

The checksum algorithm was recovered from FILMeasure.exe (decompiled ``hg.bu``) and verified against
all shipped recipes: sum of the UTF-16LE bytes of the content preceding ``CHECKSUM=`` (which includes
the End-marker line); for schema version >= 5 spaces and tabs are stripped first (CRLF are kept).
FILMeasure validates this on load, so we recompute it whenever we write a file.
"""
from __future__ import annotations

import re
from dataclasses import dataclass

_CK = "CHECKSUM="
_EOL = "\r\n"


def recipe_checksum(content: str, version: int) -> int:
    """Checksum of ``content`` (the text up to, but excluding, ``CHECKSUM=``)."""
    s = content
    if version >= 5:
        s = s.replace(" ", "").replace("\t", "")
    return sum(s.encode("utf-16-le"))


def _unquote(tok: str) -> str:
    tok = tok.strip()
    if len(tok) >= 2 and tok[0] == '"' and tok[-1] == '"':
        return tok[1:-1]
    return tok


@dataclass
class Layer:
    """A row of the ``[Layers]`` stack. ``solve_*`` flags mark parameters the fit floats."""
    layer_id: str          # "Medium", "Layer  1", "Substrate", ...
    material: str
    thickness_A: float     # angstroms
    roughness_A: float
    solve_d: bool          # solve thickness
    solve_n: bool
    solve_k: bool
    solve_r: bool
    row_index: int         # index into Recipe._lines (the raw source line)

    @property
    def thickness_nm(self) -> float:
        return self.thickness_A / 10.0


class Recipe:
    """A parsed, editable FILMeasure recipe.

    Round-trips byte-for-byte (aside from the recomputed checksum, which matches FILMeasure's).
    """

    def __init__(self, content: str, version: int, checksum_tail: str = _EOL):
        # content = exact text before "CHECKSUM=" (CRLF preserved, ends with the End-marker line + CRLF)
        self._lines = content.split(_EOL)
        self.version = version
        self._checksum_tail = checksum_tail

    # ---- construction -------------------------------------------------
    @classmethod
    def loads(cls, text: str) -> "Recipe":
        idx = text.index(_CK)
        content = text[:idx]
        m = re.search(r"Export Version.*?,\s*(\d+)", text)
        version = int(m.group(1)) if m else 12
        tail_m = re.match(r"CHECKSUM=\s*\d+(.*)$", text[idx:], re.S)
        tail = tail_m.group(1) if tail_m else _EOL
        r = cls(content, version, tail)
        r._stored_checksum = int(re.search(r"CHECKSUM=\s*(\d+)", text).group(1))
        return r

    @classmethod
    def load(cls, path: str) -> "Recipe":
        with open(path, "rb") as f:
            return cls.loads(f.read().decode("utf-8"))

    # ---- serialization ------------------------------------------------
    @property
    def content(self) -> str:
        return _EOL.join(self._lines)

    def checksum(self) -> int:
        return recipe_checksum(self.content, self.version)

    def dumps(self) -> str:
        return f"{self.content}{_CK} {self.checksum()}{self._checksum_tail}"

    def save(self, path: str) -> None:
        with open(path, "wb") as f:
            f.write(self.dumps().encode("utf-8"))

    def verify(self) -> bool:
        """True if the on-load stored checksum matches a recomputation."""
        return getattr(self, "_stored_checksum", None) == self.checksum()

    # ---- top-level fields --------------------------------------------
    def _find_kv(self, key: str):
        pat = re.compile(r"^\s*" + re.escape(key) + r"\s*,")
        for i, ln in enumerate(self._lines):
            if pat.match(ln):
                return i
        return -1

    def _get_kv(self, key: str, default=None):
        i = self._find_kv(key)
        if i < 0:
            return default
        return self._lines[i].split(",", 1)[1].strip()

    @property
    def name(self) -> str:
        return _unquote(self._get_kv("Name", ""))

    @property
    def guid(self) -> str:
        return (self._get_kv("GUID", "") or "").strip()

    @property
    def num_locations(self) -> int:
        v = self._get_kv("Num Location", "0")
        return int(float(v))

    # ---- layers -------------------------------------------------------
    @property
    def layers(self) -> list[Layer]:
        out: list[Layer] = []
        # find first "[Layers]" section
        start = next((i for i, ln in enumerate(self._lines)
                      if ln.strip().lower() == "[layers]"), -1)
        if start < 0:
            return out
        i = start + 1
        n = len(self._lines)
        # skip until we've passed the "Number of Layers" + column-header row
        seen_header = False
        while i < n:
            ln = self._lines[i]
            s = ln.strip()
            if s.startswith("[") or s.startswith("====="):
                break
            if s == "":
                if seen_header:
                    break
                i += 1
                continue
            low = s.lower()
            if low.startswith("number of layers"):
                i += 1
                continue
            if ("layer id" in low) and ("," not in s):  # the column-title row (no commas)
                seen_header = True
                i += 1
                continue
            if "," in s:
                toks = [t for t in ln.split(",")]
                if len(toks) >= 8:
                    out.append(Layer(
                        layer_id=toks[0].strip(),
                        material=_unquote(toks[1]),
                        thickness_A=float(toks[2].strip() or 0),
                        roughness_A=float(toks[3].strip() or 0),
                        solve_d=toks[4].strip().upper() == "X",
                        solve_n=toks[5].strip().upper() == "X",
                        solve_k=toks[6].strip().upper() == "X",
                        solve_r=toks[7].strip().upper() == "X",
                        row_index=i,
                    ))
            i += 1
        return out

    def set_layer_thickness(self, index: int, thickness_A: float) -> None:
        """Set the thickness (angstroms) of layer ``index`` (0-based over the parsed rows)."""
        layers = self.layers
        lay = layers[index]
        ln = self._lines[lay.row_index]
        toks = ln.split(",")
        # preserve the field's original width for readability (checksum ignores spaces anyway)
        orig = toks[2]
        val = _format_like(orig, thickness_A)
        toks[2] = val
        self._lines[lay.row_index] = ",".join(toks)

    # ---- section settings (e.g. [Acqusition Settings]) ----------------
    def section(self, name: str) -> dict[str, str]:
        """Return the ``Key -> Value`` map of a ``[Section]`` (first occurrence)."""
        head = "[" + name.strip("[]").lower() + "]"
        start = next((i for i, ln in enumerate(self._lines)
                      if ln.strip().lower() == head), -1)
        if start < 0:
            return {}
        out: dict[str, str] = {}
        for ln in self._lines[start + 1:]:
            s = ln.strip()
            if s.startswith("[") or s.startswith("====="):
                break
            if "," in s:
                k, v = s.split(",", 1)
                out[k.strip()] = v.strip()
        return out

    def __repr__(self) -> str:
        return f"<Recipe name={self.name!r} v{self.version} layers={len(self.layers)}>"


def _format_like(original: str, value: float) -> str:
    """Format ``value`` as an int if it has no fractional part, padded to the original width."""
    if float(value).is_integer():
        s = str(int(value))
    else:
        s = repr(float(value))
    width = len(original)
    lead = len(original) - len(original.lstrip(" "))
    trail = len(original) - len(original.rstrip(" "))
    core = s
    pad = width - len(core)
    if pad > 0:
        # keep it centered-ish like the source; simplest: preserve leading spaces
        return " " * max(lead, 1) + core + " " * max(pad - max(lead, 1), 1)
    return core
