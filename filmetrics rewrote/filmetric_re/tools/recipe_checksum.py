#!/usr/bin/env python3
"""
Filmetrics FILMeasure recipe checksum tool  (.fitrp / .fitra / .fiprc etc.)

Recovered from FILMeasure.exe (v8.12.6.0), decompiled method hg.bu(string, int):
    content = text up to (not including) "CHECKSUM="        # includes the
                                                            # "***End Machine Readable Structure***\r\n" line
    if version >= 5:  content = content.replace(" ", "").replace("\t", "")
    checksum = sum( content.encode("utf-16-le") )           # sum of all bytes; CRLF (\r,\n) are KEPT

FILMeasure VALIDATES this on load (hg.cs ~line 2322): a file whose trailer checksum
does not match is rejected. So after hand-editing a recipe you MUST refresh the checksum.

Usage:
    python recipe_checksum.py verify <file>...     # check stored vs computed
    python recipe_checksum.py fix    <file>...     # rewrite CHECKSUM= in place (makes a .bak)
"""
import re, sys, os, shutil

CK = b"CHECKSUM="

def _read(path):
    with open(path, "rb") as f:
        return f.read()

def _version(text):
    m = re.search(r"Export Version.*?,\s*(\d+)", text)
    return int(m.group(1)) if m else 12

def compute(data: bytes) -> int:
    """data = full file bytes (CRLF preserved). Returns the correct checksum int."""
    text = data.decode("utf-8", "replace")
    idx = text.index("CHECKSUM=")
    content = text[:idx]
    if _version(text) >= 5:
        content = content.replace(" ", "").replace("\t", "")
    return sum(content.encode("utf-16-le"))

def stored(data: bytes):
    m = re.search(rb"CHECKSUM=\s*(\d+)", data)
    return int(m.group(1)) if m else None

def fix(path):
    data = _read(path)
    idx = data.index(CK)
    prefix = data[:idx]
    # keep whatever trailing bytes followed the numeric value (usually "\r\n" or "")
    tail = b""
    m = re.match(rb"CHECKSUM=\s*\d+(.*)$", data[idx:], re.S)
    if m:
        tail = m.group(1)
    calc = compute(data)
    new = prefix + b"CHECKSUM= " + str(calc).encode("ascii") + tail   # VB Conversion.Str => leading space
    if new == data:
        print(f"[unchanged] {os.path.basename(path)} (already correct: {calc})")
        return
    shutil.copyfile(path, path + ".bak")
    with open(path, "wb") as f:
        f.write(new)
    print(f"[fixed]     {os.path.basename(path)} -> CHECKSUM= {calc}  (backup: {os.path.basename(path)}.bak)")

def verify(path):
    data = _read(path)
    s, c = stored(data), compute(data)
    ok = (s == c)
    print(f"{'OK ' if ok else 'BAD'} stored={s} computed={c}  {os.path.basename(path)}")
    return ok

def main(argv):
    if len(argv) < 3 or argv[1] not in ("verify", "fix"):
        print(__doc__); return 2
    op, files = argv[1], argv[2:]
    allok = True
    for f in files:
        try:
            (verify if op == "verify" else fix)(f)
        except Exception as e:
            allok = False; print(f"ERR {f}: {e}")
    return 0 if allok else 1

if __name__ == "__main__":
    raise SystemExit(main(sys.argv))
