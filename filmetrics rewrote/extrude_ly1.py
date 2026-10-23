"""Extrude one layer of the MEGAXY-ZP GDS and export STL.

Usage:
  python extrude_ly1.py                  # defaults: layer=1, datatype=0, 500 um
  python extrude_ly1.py 3                # layer=3, datatype=0, 500 um
  python extrude_ly1.py 3 0 500          # layer=3, datatype=0, 500 um
  python extrude_ly1.py 2 0 250          # layer=2, datatype=0, 250 um

Approach (lightweight, no gdsfactory):
  gdstk      -> read GDS polygons on the chosen layer
  shapely    -> merge overlapping/touching polygons, fix any self-intersections
  trimesh    -> extrude each connected component, concatenate, export STL
"""
import sys
from pathlib import Path
import time

import gdstk
import trimesh
from shapely.geometry import Polygon, MultiPolygon
from shapely.ops import unary_union

GDS_PATH = Path(r"C:\Users\Owner\Downloads\MEGAXY-ZP_v0.8_2026-06-01_BUILD.gds")
LAYER       = int(sys.argv[1]) if len(sys.argv) > 1 else 1
DATATYPE    = int(sys.argv[2]) if len(sys.argv) > 2 else 0
THICKNESS_UM = float(sys.argv[3]) if len(sys.argv) > 3 else 500.0
Z_BASE_UM = 0.0
OUT_PATH = Path(r"C:\Users\Owner\Downloads") / f"MEGAXY-ZP_ly{LAYER}_{int(THICKNESS_UM)}um.stl"


def main() -> None:
    t0 = time.time()
    print(f"Reading {GDS_PATH.name} ...")
    lib = gdstk.read_gds(str(GDS_PATH))
    top = lib.top_level()[0]
    print(f"  top cell: {top.name}")
    print(f"  GDS user unit: {lib.unit} m   (i.e. coordinates are in micrometers)")

    # Flatten all references and filter to layer (1, 0)
    polys = top.get_polygons(depth=None, layer=LAYER, datatype=DATATYPE)
    print(f"Layer ({LAYER}, {DATATYPE}): {len(polys)} polygons")

    # Convert to shapely, fix any invalid geometry
    shapely_polys: list[Polygon] = []
    bad = 0
    for p in polys:
        pts = p.points
        if len(pts) < 3:
            bad += 1
            continue
        sp = Polygon(pts)
        if not sp.is_valid:
            sp = sp.buffer(0)
        if sp.is_empty:
            bad += 1
            continue
        if isinstance(sp, MultiPolygon):
            shapely_polys.extend(sp.geoms)
        else:
            shapely_polys.append(sp)
    if bad:
        print(f"  skipped {bad} degenerate polygons")
    print(f"  valid shapely polygons: {len(shapely_polys)}")

    print("Merging overlapping/touching polygons ...")
    merged = unary_union(shapely_polys)
    if isinstance(merged, Polygon):
        components = [merged]
    elif isinstance(merged, MultiPolygon):
        components = list(merged.geoms)
    else:
        raise RuntimeError(f"Unexpected geometry type after union: {type(merged)}")
    print(f"  connected components after union: {len(components)}")

    print(f"Extruding by {THICKNESS_UM} um (z = {Z_BASE_UM} -> {Z_BASE_UM + THICKNESS_UM}) ...")
    meshes = []
    for i, comp in enumerate(components):
        mesh = trimesh.creation.extrude_polygon(comp, THICKNESS_UM)
        if Z_BASE_UM != 0.0:
            mesh.apply_translation((0, 0, Z_BASE_UM))
        meshes.append(mesh)
        if (i + 1) % 100 == 0 or i == len(components) - 1:
            print(f"  extruded {i + 1}/{len(components)}")

    print("Concatenating meshes ...")
    combined = trimesh.util.concatenate(meshes)
    print(f"  vertices: {len(combined.vertices):,}")
    print(f"  faces:    {len(combined.faces):,}")
    print(f"  watertight components: {combined.body_count}")
    bmin, bmax = combined.bounds
    print(f"  bounds (um):  x [{bmin[0]:.1f}, {bmax[0]:.1f}]"
          f"  y [{bmin[1]:.1f}, {bmax[1]:.1f}]"
          f"  z [{bmin[2]:.1f}, {bmax[2]:.1f}]")

    print(f"Writing {OUT_PATH} ...")
    combined.export(str(OUT_PATH))
    size_mb = OUT_PATH.stat().st_size / 1e6
    print(f"Done in {time.time() - t0:.1f}s.  STL = {size_mb:.2f} MB")


if __name__ == "__main__":
    main()
