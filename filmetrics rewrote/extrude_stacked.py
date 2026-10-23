"""Extrude the MEGAXY-ZP stack into two GLBs: 'compact' and 'disassemble'.

Semantic names map to GDS layers as follows:
    substrate   -> layer 4   (gray base)
    mems        -> layer 1   (deep blue)
    phc1        -> layer 5   (red)
    spacer      -> layer 8   (coral, thick)
    phc2        -> layer 6   (red, embedded in spacer top)
    top_layer   -> layer 7   (teal, 50% transparent)

Compact stack (z in micrometers):
    substrate   z =    0 .. 1000
    mems        z = 1000 .. 1500
    phc1        z = 1500 .. 1600
    spacer      z = 1500 .. 1800
    phc2        z = 1700 .. 1800
    top_layer   z = 1800 .. 2000

Disassemble stack: substrate + mems + phc1 + spacer stay put;
phc2 and top_layer shift UP by DISASSEMBLE_OFFSET (700 um) to expose the spacer.
"""
from dataclasses import dataclass
from pathlib import Path
import time

import gdstk
import trimesh
from trimesh.visual.material import PBRMaterial
from shapely.geometry import Polygon, MultiPolygon
from shapely.ops import unary_union

GDS_PATH  = Path(r"C:\Users\Owner\Harvard University Dropbox\Haoning Tang\Tania proposal\MEGAXY-ZP_v0.8_2026-06-01_BUILD_2.gds")
OUT_DIR   = Path(r"C:\Users\Owner\Harvard University Dropbox\Haoning Tang\Tania proposal")
DISASSEMBLE_OFFSET = 1600.0   # um — phc2 + top_layer move up so spacer-top to phc2-bottom gap = 1500 um


@dataclass(frozen=True)
class LayerSpec:
    name: str           # semantic name
    layer: int          # GDS layer number
    datatype: int
    hex_color: str
    alpha: int          # 0..255  (255 = opaque)
    z_base: float       # compact-mode z_base, micrometers
    thickness: float
    movable: bool       # if True, shifts up in disassemble mode


LAYERS: list[LayerSpec] = [
    LayerSpec("substrate", 4, 0, "#808080", 255,    0.0, 1000.0, movable=False),
    LayerSpec("mems",      1, 0, "#082E5C", 255, 1000.0,  500.0, movable=False),
    LayerSpec("phc1",      5, 0, "#703646", 255, 1500.0,  100.0, movable=False),
    LayerSpec("spacer",    8, 0, "#d88a66", 255, 1500.0,  300.0, movable=False),
    LayerSpec("phc2",      6, 0, "#18144C", 255, 1700.0,  100.0, movable=True),
    LayerSpec("top_layer", 7, 0, "#5abeaf",  77, 1800.0,  200.0, movable=True),
]


def hex_to_rgb01(hex_str: str) -> tuple[float, float, float]:
    h = hex_str.lstrip("#")
    return (int(h[0:2], 16) / 255, int(h[2:4], 16) / 255, int(h[4:6], 16) / 255)


def make_material(spec: LayerSpec) -> PBRMaterial:
    r, g, b = hex_to_rgb01(spec.hex_color)
    a = spec.alpha / 255.0
    return PBRMaterial(
        name=spec.name,
        baseColorFactor=[r, g, b, a],
        alphaMode="BLEND" if spec.alpha < 255 else "OPAQUE",
        metallicFactor=0.0,
        roughnessFactor=0.6,
        doubleSided=True,
    )


def extrude_layer(top_cell, spec: LayerSpec, z_base: float) -> trimesh.Trimesh:
    polys = top_cell.get_polygons(depth=None, layer=spec.layer, datatype=spec.datatype)
    print(f"    {spec.name:9} (ly{spec.layer}): {len(polys)} polygons", end="")

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

    meshes = []
    for comp in components:
        m = trimesh.creation.extrude_polygon(comp, spec.thickness)
        if z_base != 0.0:
            m.apply_translation((0, 0, z_base))
        meshes.append(m)

    combined = trimesh.util.concatenate(meshes)
    bmin, bmax = combined.bounds
    print(f"  ->  z=[{bmin[2]:.0f}, {bmax[2]:.0f}]  "
          f"({len(combined.vertices):,} v / {len(combined.faces):,} f)")
    return combined


def build_scene(top_cell, mode: str) -> trimesh.Scene:
    assert mode in ("compact", "disassemble")
    offset = DISASSEMBLE_OFFSET if mode == "disassemble" else 0.0
    scene = trimesh.Scene()
    print(f"\n--- Building '{mode}' (movable layers offset by {offset:.0f} um) ---")
    for spec in LAYERS:
        z_base = spec.z_base + (offset if spec.movable else 0.0)
        mesh = extrude_layer(top_cell, spec, z_base)
        mesh.visual = trimesh.visual.TextureVisuals(material=make_material(spec))
        scene.add_geometry(mesh, node_name=spec.name, geom_name=spec.name)
    return scene


def main() -> None:
    t0 = time.time()
    print(f"Reading {GDS_PATH.name} ...")
    lib = gdstk.read_gds(str(GDS_PATH))
    top = lib.top_level()[0]

    for mode in ("compact", "disassemble"):
        scene = build_scene(top, mode)
        out = OUT_DIR / f"MEGAXY-ZP_{mode}.glb"
        scene.export(str(out))
        print(f"  -> {out.name}  ({out.stat().st_size / 1e6:.2f} MB)")

    print(f"\nDone in {time.time() - t0:.1f}s")


if __name__ == "__main__":
    main()
