"""Print materials of every mesh in the GLB so we can confirm colors + alphaMode."""
import trimesh
s = trimesh.load(r"C:\Users\Owner\Downloads\MEGAXY-ZP_BUILD2_stacked_v2.glb")
for name, g in s.geometry.items():
    m = getattr(g.visual, "material", None)
    if m is None:
        print(f"{name:12}  (no material)")
        continue
    color = getattr(m, "baseColorFactor", None)
    mode  = getattr(m, "alphaMode", None)
    if color is not None:
        r, g_, b, a = [round(float(x), 3) for x in color]
        print(f"{name:12}  rgba=({r}, {g_}, {b}, {a})  alphaMode={mode}")
    else:
        print(f"{name:12}  material={m}")
