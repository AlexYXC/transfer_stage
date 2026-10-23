"""Dump the JSON chunk of the GLB to see the raw glTF materials."""
import json
import struct
from pathlib import Path

p = Path(r"C:\Users\Owner\Downloads\MEGAXY-ZP_BUILD2_stacked_v2.glb")
data = p.read_bytes()
# GLB header: magic(4) + version(4) + length(4), then chunks: each chunkLen(4) + chunkType(4) + data
assert data[:4] == b"glTF"
chunk_len = struct.unpack("<I", data[12:16])[0]
chunk_type = data[16:20]
assert chunk_type == b"JSON"
json_bytes = data[20:20 + chunk_len].rstrip(b"\x00 ")
gltf = json.loads(json_bytes)

for mat in gltf.get("materials", []):
    name = mat.get("name", "?")
    pbr = mat.get("pbrMetallicRoughness", {})
    color = pbr.get("baseColorFactor")
    mode = mat.get("alphaMode", "OPAQUE")
    print(f"{name:12}  baseColorFactor={color}  alphaMode={mode}")
