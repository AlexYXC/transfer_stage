"""Staged, read-only-first hardware validation for the FIUsbInt.dll device backend.

Run on the PC with the instrument, using 32-bit Python (FIUsbInt.dll is x86):
    python validate_hardware.py                 # Stage 0-2 only: env + enumerate + identity (READ-ONLY)
    python validate_hardware.py --lamp          # + Stage 3: lamp on/off (reversible)
    python validate_hardware.py --acquire       # + Stage 4: dark + reference acquisition
    python validate_hardware.py --measure PATH.fitrp   # + Stage 5: baseline + measure a recipe

This NEVER calls firmware/calibration/EEPROM writes (see HARDWARE_VALIDATION.md). Read-only stages come
first; physical actions are gated behind flags so you opt in.
"""
import argparse
import struct
import sys


def _ok(msg): print(f"  [OK]   {msg}")
def _warn(msg): print(f"  [WARN] {msg}")
def _fail(msg): print(f"  [FAIL] {msg}")


def stage0_env():
    print("\n== Stage 0: environment (read-only) ==")
    bits = struct.calcsize("P") * 8
    (_ok if bits == 32 else _fail)(f"Python is {bits}-bit "
                                   + ("" if bits == 32 else "-> FIUsbInt.dll is 32-bit; use 32-bit Python!"))
    try:
        import comtypes.client  # noqa
        _ok("comtypes present")
    except Exception as e:
        _fail(f"comtypes missing: {e}  (pip install comtypes)"); return False
    import comtypes.client
    all_ok = True
    for progid in ("FIUsbInt.FMusbEnum.1", "FIUsbInt.FIUsbController.1", "FIUsbInt.FIUsbSpectrometer.1"):
        try:
            comtypes.client.CreateObject(progid); _ok(f"ProgID resolves: {progid}")
        except Exception as e:
            _fail(f"ProgID missing: {progid} ({e})"); all_ok = False
    return bits == 32 and all_ok


def stage1_enumerate():
    print("\n== Stage 1: enumerate controllers (read-only) ==")
    from filmeas.device.fiusbint import enumerate_controllers
    try:
        ctrls = enumerate_controllers()
    except Exception as e:
        _fail(f"enumeration failed: {e}"); return False
    if not ctrls:
        _warn("no controllers reported (device unplugged, still Unbooted, or held by FILMeasure)"); return False
    for c in ctrls:
        _ok(f"controller[{c['index']}] raw={c['raw']}")
    return True


def stage2_identity():
    print("\n== Stage 2: connect + identity (read-only) ==")
    from filmeas.device.fiusbint import FIUsbInstrument
    inst = FIUsbInstrument()
    try:
        inst.connect()
    except Exception as e:
        _fail(f"connect failed: {e}"); return None
    try:
        s = inst._spec
        _ok(f"SerialNumber      = {s.SerialNumber}")
        _ok(f"NumPixels         = {inst.num_pixels}")
        _ok(f"eSpectromType     = {s.eSpectromType}")
        _ok(f"Integration min/max = {inst.min_integration_time_ms}/{inst.max_integration_time_ms} ms")
        wl = inst.wavelengths_nm
        _ok(f"Wavelength range  = {wl[0]:.1f} .. {wl[-1]:.1f} nm  "
            f"(cal off/slope/curv = {s.FWCalOffset}/{s.FWCalSlope}/{s.FWCalCurv})")
        _ok(f"Controller model  = {inst.model}")
    except Exception as e:
        _fail(f"identity read failed: {e}")
    return inst


def stage3_lamp(inst):
    print("\n== Stage 3: lamp on/off (reversible) ==")
    try:
        inst.set_light(True); _ok("lamp ON  (look: is it lit?)")
        inst.set_light(False); _ok("lamp OFF")
    except Exception as e:
        _fail(f"lamp control failed: {e}")


def stage4_acquire(inst):
    print("\n== Stage 4: dark + reference acquisition (reversible) ==")
    try:
        inst.integration_time_ms = 40.0
        inst.set_light(False)
        dark = inst.acquire(averages=4)
        inst.set_light(True)
        ref = inst.acquire(averages=4)
        _ok(f"dark  counts: min/max = {dark.counts.min():.0f}/{dark.counts.max():.0f}  zero_err={dark.zero_error}")
        _ok(f"ref   counts: min/max = {ref.counts.min():.0f}/{ref.counts.max():.0f}  sat={ref.saturated}")
        if ref.counts.max() > dark.counts.max() * 3 and not ref.saturated:
            _ok("reference well above dark and not saturated -> acquisition path works")
        else:
            _warn("reference not clearly above dark or saturated -> adjust integration/standard")
    except Exception as e:
        _fail(f"acquisition failed: {e}")


def stage5_measure(inst, recipe_path):
    print(f"\n== Stage 5: baseline + measure ({recipe_path}) ==")
    from filmeas.app.controller import MeasureController
    from filmeas.io.recipe import Recipe
    recipe = Recipe.load(recipe_path)
    ctrl = MeasureController(inst)
    input("  Place the REFERENCE standard under the probe, then press Enter...")
    ctrl.take_baseline(_ref_material(recipe), averages=9)
    input("  Place the SAMPLE under the probe, then press Enter...")
    res = ctrl.measure(recipe, averages=9)
    _ok(f"thickness = {', '.join(f'{t:.0f} A' for t in res.thickness_A)}   GOF = {res.gof:.4f}")


def _ref_material(recipe):
    acq = recipe.section("Acqusition Settings")
    return (acq.get("<Reference Material1>", "").strip().strip('"')) or "Si"


def main(argv=None):
    ap = argparse.ArgumentParser(description=__doc__)
    ap.add_argument("--lamp", action="store_true", help="also toggle the lamp (Stage 3)")
    ap.add_argument("--acquire", action="store_true", help="also acquire dark+reference (Stage 4)")
    ap.add_argument("--measure", metavar="RECIPE", help="also baseline+measure a recipe (Stage 5)")
    args = ap.parse_args(argv)

    if not stage0_env():
        print("\nStage 0 failed — fix the environment before continuing."); return 1
    if not stage1_enumerate():
        print("\nStage 1 found no device — stopping."); return 1
    inst = stage2_identity()
    if inst is None:
        return 1
    try:
        if args.lamp:
            stage3_lamp(inst)
        if args.acquire:
            stage4_acquire(inst)
        if args.measure:
            stage5_measure(inst, args.measure)
    finally:
        inst.close()
    print("\nDone.")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
