"""Extrude multiple layers from the modified MEGAXY-ZP GDS (_BUILD_2).

Outputs:
  1. Individual STL per layer (uncolored — STL doesn't store color)
  2. Combined GLB with colors baked in:
       - layer 1  -> teal     (RGB 32, 178, 170)
       - layer 4  -> gray     (RGB 185, 188, 198, matches CleWin default)

Open the GLB with Windows 3D Viewer, Blender, or any glTF viewer to see colors.
The STLs are plain geometry — color them in your viewer if you prefer STL.
"""
from pathlib import Path
import time

import gdstk
import numpy as np
import trimesh
from shapely.geometry import Polygon, MultiPolygon
from shapely.ops import unary_union

GDS_PATH = Path(r"C:\Users\Owner\Downloads\MEGAXY-ZP_v0.8_2026-06-01_BUILD_2.gds")
OUT_DIR  = Path(r"C:\Users\Owner\Downloads")
THICKNESS_UM = 500.0
Z_BASE_UM = 0.0

# (layer, datatype, RGBA color for GLB)
LAYERS = [
    (1, 0, (32, 178, 170, 255)),    # teal
    (4, 0, (185, 188, 198, 255)),   # silvery gray
]


def extrude_layer(top_cell, layer: int, datatype: int, thickness: float) -> trimesh.Trimesh:
    polys = top_cell.get_polygons(depth=None, layer=layer, datatype=datatype)
    print(f"  layer ({layer}, {datatype}): {len(polys)} polygons")

    shapely_polys: list[Polygon] = []
    for p in polys:
        pts = p.points
        if len(pts) < 3:
            continue
        sp = Polygon(pts)
        if not sp.is_valid:
            sp = sp.buffer(0)
        if sp.is_empty:
            continue
        if isinstance(sp, MultiPolygon):
            shapely_polys.extend(sp.geoms)
        else:
            shapely_polys.append(sp)

    merged = unary_union(shapely_polys)
    if isinstance(merged, Polygon):
        components = [merged]
    elif isinstance(merged, MultiPolygon):
        components = list(merged.geoms)
    else:
        components = []
    print(f"    -> {len(components)} connected component(s) after union")

    meshes = []
    for i, comp in enumerate(components):
        m = trimesh.creation.extrude_polygon(comp, thickness)
        if Z_BASE_UM != 0.0:
            m.apply_translation((0, 0, Z_BASE_UM))
        meshes.append(m)
        if len(components) > 100 and (i + 1) % 1000 == 0:
            print(f"    extruded {i + 1}/{len(components)}")

    combined = trimesh.util.concatenate(meshes)
    print(f"    -> mesh: {len(combined.vertices):,} verts / {len(combined.faces):,} faces")
    return combined


def main() -> None:
    t0 = time.time()
    print(f"Reading {GDS_PATH.name} ...")
    lib = gdstk.read_gds(str(GDS_PATH))
    top = lib.top_level()[0]

    scene = trimesh.Scene()
    for layer, datatype, rgba in LAYERS:
        print(f"\n=== Layer ({layer}, {datatype}) ===")
        mesh = extrude_layer(top, layer, datatype, THICKNESS_UM)

        stl_path = OUT_DIR / f"MEGAXY-ZP_BUILD2_ly{layer}_{int(THICKNESS_UM)}um.stl"
        print(f"    writing STL -> {stl_path.name}")
        mesh.export(str(stl_path))
        print(f"    STL size: {stl_path.stat().st_size / 1e6:.2f} MB")

        # Color a copy for the combined GLB scene
        colored = mesh.copy()
        colored.visual.face_colors = np.array(rgba, dtype=np.uint8)
        scene.add_geometry(colored, node_name=f"layer_{layer}")

    glb_path = OUT_DIR / "MEGAXY-ZP_BUILD2_ly1+ly4_500um.glb"
    print(f"\nWriting combined colored GLB -> {glb_path.name}")
    scene.export(str(glb_path))
    print(f"GLB size: {glb_path.stat().st_size / 1e6:.2f} MB")

    print(f"\nDone in {time.time() - t0:.1f}s")


if __name__ == "__main__":
    main()
