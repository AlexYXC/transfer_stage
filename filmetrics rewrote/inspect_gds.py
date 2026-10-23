"""Inspect a GDS file: list all (layer, datatype) pairs and cell counts."""
import gdstk
from collections import Counter
from pathlib import Path

gds_path = Path(r"C:\Users\Owner\Downloads\MEGAXY-ZP_v0.8_2026-06-01_BUILD_2.gds")

lib = gdstk.read_gds(str(gds_path))

print(f"File: {gds_path.name}")
print(f"Unit: {lib.unit} m, Precision: {lib.precision} m")
print(f"Top cells: {[c.name for c in lib.top_level()]}")
print(f"Total cells: {len(lib.cells)}")
print()

layer_counts = Counter()
layer_polygons = Counter()
for cell in lib.cells:
    for poly in cell.polygons:
        key = (poly.layer, poly.datatype)
        layer_counts[key] += 1
    for path in cell.paths:
        for layer, datatype in zip(path.layers, path.datatypes):
            layer_counts[(layer, datatype)] += 1

print(f"{'(layer, datatype)':<20} {'shape_count':>12}")
print("-" * 35)
for key in sorted(layer_counts):
    print(f"{str(key):<20} {layer_counts[key]:>12}")

print()
top = lib.top_level()
if top:
    bb = top[0].bounding_box()
    if bb:
        (x0, y0), (x1, y1) = bb
        print(f"Top cell bbox (um): ({x0:.2f}, {y0:.2f}) -> ({x1:.2f}, {y1:.2f})")
        print(f"Size: {x1-x0:.2f} x {y1-y0:.2f} um")
