"""Hero figure for the proposal: 'Discrimination at the optical front-end, not the digital back-end.'

Layout (cool IR / night-vision aesthetic):

  +---- title bar -----------------------------------------------------------+
  |  TOP TRACK (traditional, dead gray) :                                    |
  |    [camo+target+decoy scene]  -> [fixed lens]  -> [gray fog]  |WALL| -> FAIL
  |                                                                         |
  |  BOTTOM TRACK (proposed, IR teal) :                                     |
  |    [same scene]  -> [MEMS chip 3D]  -> [K-dim fingerprint]   |WALL| -> TARGET
  +-------------------------------------------------------------------------+

Outputs hero_figure.png (300 DPI) + hero_figure.svg.
"""
from pathlib import Path

import numpy as np
import matplotlib.pyplot as plt
import matplotlib.patches as mpatches
from matplotlib.patches import FancyArrowPatch, FancyBboxPatch, Rectangle, Circle, RegularPolygon
from matplotlib.collections import PatchCollection
from matplotlib.lines import Line2D
from matplotlib.transforms import Affine2D
import matplotlib.colors as mcolors
from mpl_toolkits.mplot3d.art3d import Poly3DCollection
import trimesh

# ----------------------------- config ---------------------------------------
OUT_DIR    = Path(r"C:\Users\Owner\Harvard University Dropbox\Haoning Tang\Tania proposal")
GLB_PATH   = OUT_DIR / "MEGAXY-ZP_compact.glb"
OUT_PNG    = OUT_DIR / "hero_figure.png"
OUT_SVG    = OUT_DIR / "hero_figure.svg"

FIG_W, FIG_H = 14, 7.8         # inches
DPI          = 300

# Palette ("cool IR / night-vision")
BG          = "#0a1018"        # background near-black navy
PANEL_DEAD  = "#171c24"        # top track panel bg
PANEL_LIVE  = "#0e1a22"        # bottom track panel bg (slight teal lift)
WALL_GLOW   = "#7fffd4"        # ADC wall, glowing teal
TEAL        = "#5abeaf"        # primary live IR
TEAL_DEEP   = "#1f6b66"        # darker live
DEAD_GRAY   = "#3a4048"        # top track elements
DEAD_GRAY_D = "#262b33"        # top track darker
TARGET_HOT  = "#ff6b3d"        # target warm accent
DECOY_AMBER = "#d18b3a"        # decoy similar to target in plain view
TEXT        = "#e6efee"        # primary text
TEXT_DIM    = "#7d8a90"        # secondary
RED_FAIL    = "#ff4d4d"        # FAIL accent
GREEN_OK    = "#5dff9a"        # SUCCESS accent

plt.rcParams.update({
    "font.family": "DejaVu Sans",
    "font.size": 11,
    "axes.edgecolor": TEXT_DIM,
    "axes.labelcolor": TEXT,
    "xtick.color": TEXT_DIM,
    "ytick.color": TEXT_DIM,
})


# ----------------------------- helpers --------------------------------------
def ir_tint(rgb01, strength=0.55):
    """Push an RGB color toward the cool-teal IR palette."""
    r, g, b = rgb01
    target = np.array([0.20, 0.74, 0.68])      # teal ~ #33bca8
    cur    = np.array([r, g, b])
    mixed  = (1 - strength) * cur + strength * target
    # Slight overall darkening for night-vision feel
    return tuple(np.clip(mixed * 0.85, 0, 1))


def add_glow_text(ax, x, y, text, color, fontsize=12, weight="bold",
                  glow_color=None, glow_alpha=0.4, n_layers=4, **kwargs):
    """Render text with a soft chromatic glow underneath."""
    if glow_color is None:
        glow_color = color
    # underlayers
    for i in range(n_layers, 0, -1):
        ax.text(x, y, text, color=glow_color, fontsize=fontsize, weight=weight,
                alpha=glow_alpha * (i / n_layers) * 0.3,
                path_effects=[], **kwargs)
    ax.text(x, y, text, color=color, fontsize=fontsize, weight=weight, **kwargs)


def panel_rect(ax, x, y, w, h, fc, ec=None, alpha=1.0, lw=0.8, radius=0.012):
    """Rounded rectangle panel background."""
    if ec is None:
        ec = TEXT_DIM
    p = FancyBboxPatch((x, y), w, h, boxstyle=f"round,pad=0.005,rounding_size={radius}",
                       facecolor=fc, edgecolor=ec, linewidth=lw, alpha=alpha,
                       transform=ax.transAxes, zorder=0.5)
    ax.add_patch(p)


# ----------------------------- chip 3D --------------------------------------
def render_chip_to_axes(ax3d, glb_path, ir_strength=0.55):
    """Load GLB and render with cool-IR tint into ax3d (a 3D axes)."""
    scene = trimesh.load(str(glb_path))
    # Compute global bounds first for consistent scale
    all_pts = []
    for _, m in scene.geometry.items():
        all_pts.append(m.vertices)
    all_pts = np.vstack(all_pts)
    center = all_pts.mean(axis=0)

    for name, mesh in scene.geometry.items():
        verts = mesh.vertices - center
        faces = mesh.faces
        mat = getattr(mesh.visual, "material", None)
        if mat is not None and getattr(mat, "baseColorFactor", None) is not None:
            base = [float(v) for v in mat.baseColorFactor]
            # trimesh sometimes returns 0-255; normalize to 0-1
            if max(base) > 1.0:
                base = [v / 255.0 for v in base]
            color = ir_tint(base[:3], strength=ir_strength)
            alpha = float(base[3]) if len(base) > 3 else 1.0
            alpha = max(0.0, min(1.0, alpha))
        else:
            color = ir_tint((0.5, 0.5, 0.5), strength=ir_strength)
            alpha = 1.0
        face_verts = verts[faces]
        poly = Poly3DCollection(face_verts, alpha=alpha, facecolor=color,
                                edgecolor="none", linewidth=0)
        # add a subtle teal rim by slightly brightening
        poly.set_zsort("max")
        ax3d.add_collection3d(poly)

    # Bounds for view
    mn = (all_pts - center).min(axis=0)
    mx = (all_pts - center).max(axis=0)
    ax3d.set_xlim(mn[0] * 1.05, mx[0] * 1.05)
    ax3d.set_ylim(mn[1] * 1.05, mx[1] * 1.05)
    ax3d.set_zlim(mn[2] * 1.05, mx[2] * 1.05)
    ax3d.set_box_aspect((1, 1, 0.55))
    ax3d.view_init(elev=22, azim=-58)
    ax3d.set_axis_off()
    ax3d.set_facecolor((0, 0, 0, 0))


# ----------------------------- scene block ----------------------------------
def draw_scene_block(ax, dead=False):
    """Camo background + target + decoy that look identical in plain view."""
    ax.set_xlim(0, 1); ax.set_ylim(0, 1)
    ax.set_facecolor("none")
    ax.set_xticks([]); ax.set_yticks([])
    for sp in ax.spines.values():
        sp.set_visible(False)

    # background camo: irregular blobs
    rng = np.random.default_rng(7)
    if dead:
        base_colors = ["#1d2129", "#262b33", "#2f343c", "#3a4048"]
    else:
        base_colors = ["#0e2422", "#15302d", "#1d4039", "#2a5b54"]
    for _ in range(38):
        cx, cy = rng.uniform(0, 1, 2)
        r = rng.uniform(0.06, 0.16)
        c = rng.choice(base_colors)
        # ellipse-ish patch
        ax.add_patch(mpatches.Ellipse((cx, cy), r * rng.uniform(0.7, 1.3),
                                       r * rng.uniform(0.7, 1.3),
                                       facecolor=c, edgecolor="none", alpha=0.85))

    # target (true hot object — but at same INTENSITY as decoy in plain view)
    tgt_col = DEAD_GRAY if dead else TARGET_HOT
    ax.add_patch(Circle((0.30, 0.55), 0.055, facecolor=tgt_col,
                        edgecolor=TEXT_DIM if dead else "#ffd2b0",
                        linewidth=1.0, alpha=0.95, zorder=3))
    # decoy (same brightness in passive intensity)
    dec_col = DEAD_GRAY if dead else DECOY_AMBER
    ax.add_patch(Circle((0.70, 0.40), 0.055, facecolor=dec_col,
                        edgecolor=TEXT_DIM if dead else "#e8c595",
                        linewidth=1.0, alpha=0.95, zorder=3))

    # labels
    lbl_col = TEXT_DIM if dead else TEXT
    ax.text(0.30, 0.66, "target", color=lbl_col, fontsize=8.5, ha="center")
    ax.text(0.70, 0.30, "decoy", color=lbl_col, fontsize=8.5, ha="center")

    # outer frame
    ax.add_patch(Rectangle((0.005, 0.005), 0.99, 0.99,
                           facecolor="none",
                           edgecolor=TEXT_DIM if dead else TEAL_DEEP,
                           linewidth=1.0))


# ----------------------------- main draw ------------------------------------
def main():
    fig = plt.figure(figsize=(FIG_W, FIG_H), facecolor=BG)
    fig.patch.set_facecolor(BG)

    # ============ TITLE BAR ============
    fig.text(0.5, 0.955,
             "Discrimination at the optical front-end, not the digital back-end",
             color=TEXT, fontsize=22, weight="bold", ha="center", family="DejaVu Sans")
    fig.text(0.5, 0.915,
             "MEMS-reconfigurable metasurface poses a sequence of physical optical questions before the photon ever becomes a bit",
             color=TEXT_DIM, fontsize=11.5, ha="center", style="italic")

    # ============ ZONES ============
    # x:  side(.00-.07) | scene(.08-.24) | optics(.25-.43) | data(.44-.55) | WALL(.555-.580) | outcome(.595-.985)
    # y:  bottom track .055-.42   top track .46-.82
    Y_TOP  = (0.46, 0.82)
    Y_BOT  = (0.055, 0.42)
    X_SCN  = (0.08, 0.24)
    X_OPT  = (0.25, 0.43)
    X_DAT  = (0.44, 0.55)
    X_WAL  = (0.557, 0.580)
    X_OUT  = (0.595, 0.985)

    # Track backgrounds
    fig.add_artist(FancyBboxPatch(
        (X_SCN[0] - 0.005, Y_TOP[0] - 0.015),
        X_OUT[1] - X_SCN[0] + 0.01, Y_TOP[1] - Y_TOP[0] + 0.03,
        transform=fig.transFigure,
        boxstyle="round,pad=0.005,rounding_size=0.01",
        facecolor=PANEL_DEAD, edgecolor="#2c333c", linewidth=0.8, zorder=0))
    fig.add_artist(FancyBboxPatch(
        (X_SCN[0] - 0.005, Y_BOT[0] - 0.015),
        X_OUT[1] - X_SCN[0] + 0.01, Y_BOT[1] - Y_BOT[0] + 0.03,
        transform=fig.transFigure,
        boxstyle="round,pad=0.005,rounding_size=0.01",
        facecolor=PANEL_LIVE, edgecolor="#1f3a3a", linewidth=0.8, zorder=0))

    # Track labels (left margin) — horizontal, in the left side gutter
    fig.text(0.04, (Y_TOP[0] + Y_TOP[1]) / 2 + 0.03,
             "TRADITIONAL", color=TEXT_DIM, fontsize=11, weight="bold",
             ha="center", va="center", rotation=90)
    fig.text(0.058, (Y_TOP[0] + Y_TOP[1]) / 2 - 0.02,
             "passive imaging\n+ backend algorithm",
             color=TEXT_DIM, fontsize=7.5, ha="center", va="center", rotation=90,
             linespacing=1.1)
    fig.text(0.04, (Y_BOT[0] + Y_BOT[1]) / 2 + 0.03,
             "MEMS  C–R", color=TEAL, fontsize=11, weight="bold",
             ha="center", va="center", rotation=90)
    fig.text(0.058, (Y_BOT[0] + Y_BOT[1]) / 2 - 0.025,
             "reconfigurable\noptical operators",
             color=TEAL, fontsize=7.5, ha="center", va="center", rotation=90,
             linespacing=1.1)

    # ============ DOMAIN LABELS ============ (below subtitle, above panels)
    fig.text((X_SCN[0] + X_DAT[1]) / 2, 0.870,
             "OPTICAL DOMAIN  —  photons, before ADC",
             color=TEAL, fontsize=10, ha="center", weight="bold",
             alpha=0.90)
    fig.text((X_OUT[0] + X_OUT[1]) / 2, 0.870,
             "DIGITAL DOMAIN  —  bits, after ADC",
             color=TEXT_DIM, fontsize=10, ha="center", weight="bold",
             alpha=0.90)

    # ============ SCENE PANELS ============
    ax_scn_t = fig.add_axes([X_SCN[0], Y_TOP[0], X_SCN[1] - X_SCN[0], Y_TOP[1] - Y_TOP[0]])
    draw_scene_block(ax_scn_t, dead=True)
    ax_scn_t.text(0.5, -0.08, "$I_\\mathrm{target} \\approx I_\\mathrm{decoy}$",
                  transform=ax_scn_t.transAxes, ha="center", color=TEXT_DIM, fontsize=10)

    ax_scn_b = fig.add_axes([X_SCN[0], Y_BOT[0], X_SCN[1] - X_SCN[0], Y_BOT[1] - Y_BOT[0]])
    draw_scene_block(ax_scn_b, dead=False)
    ax_scn_b.text(0.5, -0.08, "same scene", transform=ax_scn_b.transAxes,
                  ha="center", color=TEAL, fontsize=10)

    # ============ TOP TRACK — TRADITIONAL OPTICS ============
    ax_opt_t = fig.add_axes([X_OPT[0], Y_TOP[0], X_OPT[1] - X_OPT[0], Y_TOP[1] - Y_TOP[0]])
    ax_opt_t.set_xlim(0, 1); ax_opt_t.set_ylim(0, 1)
    ax_opt_t.set_xticks([]); ax_opt_t.set_yticks([]); ax_opt_t.set_facecolor("none")
    for sp in ax_opt_t.spines.values():
        sp.set_visible(False)
    # fixed lens icon
    ax_opt_t.add_patch(mpatches.Ellipse((0.25, 0.55), 0.20, 0.55,
                                         facecolor=DEAD_GRAY_D,
                                         edgecolor=DEAD_GRAY, linewidth=1.5))
    ax_opt_t.text(0.25, 0.16, "fixed lens", color=TEXT_DIM, ha="center", fontsize=8.5)
    # rays in (parallel gray)
    for y in np.linspace(0.30, 0.80, 5):
        ax_opt_t.add_patch(FancyArrowPatch((0.00, y), (0.15, 0.55),
                                            arrowstyle="-", color=DEAD_GRAY,
                                            linewidth=0.8, alpha=0.6))
    # mixed output -> gray fog
    fog_x = np.linspace(0.42, 0.95, 80)
    fog_y_top = 0.78 + 0.05 * np.sin(fog_x * 12)
    fog_y_bot = 0.30 + 0.05 * np.cos(fog_x * 9)
    rng = np.random.default_rng(11)
    for _ in range(120):
        cx = rng.uniform(0.42, 0.95)
        cy = rng.uniform(0.30, 0.82)
        ax_opt_t.add_patch(Circle((cx, cy), rng.uniform(0.015, 0.045),
                                   facecolor=DEAD_GRAY, alpha=rng.uniform(0.10, 0.35),
                                   edgecolor="none"))
    ax_opt_t.text(0.66, 0.96, "mixed photons", color=TEXT_DIM, ha="center", fontsize=9)
    ax_opt_t.text(0.66, 0.07,
                  "fixed operator integrates target & decoy\ninto the same signal",
                  color=TEXT_DIM, ha="center", fontsize=8.5, style="italic")

    # ============ BOTTOM TRACK — MEMS chip + fingerprint ============
    ax_chip = fig.add_axes([X_OPT[0], Y_BOT[0] - 0.02, X_OPT[1] - X_OPT[0], Y_BOT[1] - Y_BOT[0] + 0.04],
                           projection="3d")
    render_chip_to_axes(ax_chip, GLB_PATH)
    # interrogation beams: 4 cyan beams coming in (left)
    ax_beams = fig.add_axes([X_OPT[0] - 0.005, Y_BOT[0], X_OPT[1] - X_OPT[0], Y_BOT[1] - Y_BOT[0]])
    ax_beams.set_xlim(0, 1); ax_beams.set_ylim(0, 1); ax_beams.set_facecolor("none")
    ax_beams.set_xticks([]); ax_beams.set_yticks([])
    for sp in ax_beams.spines.values():
        sp.set_visible(False)
    beam_glyphs = [("χ", "chirality"), ("p", "polarization"), ("λ", "spectral"), ("θ", "angle")]
    for i, (glyph, label) in enumerate(beam_glyphs):
        y_end = 0.40 + i * 0.04
        for w, a in [(3.0, 0.18), (1.6, 0.40), (0.8, 0.85)]:
            ax_beams.plot([0.00, 0.30], [0.20 + i * 0.13, y_end], color=TEAL,
                          linewidth=w, alpha=a, solid_capstyle="round")
        ax_beams.text(-0.01, 0.20 + i * 0.13, glyph, color=TEAL, fontsize=12,
                      ha="right", va="center", weight="bold", family="DejaVu Sans")
    ax_beams.text(0.15, 0.93,
                  "K reconfigurable operators\n$A(u_1),\\ A(u_2),\\ \\dots,\\ A(u_K)$",
                  color=TEAL, ha="center", fontsize=9.5, weight="bold")
    ax_beams.text(0.65, 0.06, "MEMS metasurface", color=TEAL, ha="center",
                  fontsize=9, weight="bold")

    # Data column (top track: dummy fog; bottom track: fingerprint plot)
    ax_dat_t = fig.add_axes([X_DAT[0], Y_TOP[0] + 0.02, X_DAT[1] - X_DAT[0], Y_TOP[1] - Y_TOP[0] - 0.04])
    ax_dat_t.set_xlim(0, 1); ax_dat_t.set_ylim(0, 1); ax_dat_t.set_facecolor("none")
    ax_dat_t.set_xticks([]); ax_dat_t.set_yticks([])
    for sp in ax_dat_t.spines.values():
        sp.set_visible(False)
    # smear/fog representing lost discriminating info
    rng = np.random.default_rng(31)
    for _ in range(300):
        cx = rng.uniform(0.05, 0.95); cy = rng.uniform(0.10, 0.90)
        ax_dat_t.add_patch(Circle((cx, cy), rng.uniform(0.005, 0.025),
                                   facecolor=DEAD_GRAY, alpha=rng.uniform(0.10, 0.35),
                                   edgecolor="none"))
    ax_dat_t.text(0.5, 0.95, "detector readout", color=TEXT_DIM, ha="center",
                  fontsize=9, weight="bold")
    ax_dat_t.text(0.5, 0.05,
                  "information already averaged away",
                  color=TEXT_DIM, ha="center", fontsize=8.5, style="italic")
    # frame
    ax_dat_t.add_patch(Rectangle((0.01, 0.01), 0.98, 0.98, facecolor="none",
                                  edgecolor=DEAD_GRAY, linewidth=0.8))

    ax_dat_b = fig.add_axes([X_DAT[0], Y_BOT[0] + 0.02, X_DAT[1] - X_DAT[0], Y_BOT[1] - Y_BOT[0] - 0.04])
    ax_dat_b.set_facecolor("none")
    ax_dat_b.set_xlim(0, 6); ax_dat_b.set_ylim(-0.15, 1.15)
    ax_dat_b.set_xticks([]); ax_dat_b.set_yticks([])
    for sp in ax_dat_b.spines.values():
        sp.set_visible(False)
    k = np.arange(1, 7)
    target_resp = np.array([0.92, 0.18, 0.85, 0.30, 0.95, 0.12])
    decoy_resp  = np.array([0.46, 0.49, 0.50, 0.48, 0.50, 0.47])
    ax_dat_b.plot(k, target_resp, "-o", color=TARGET_HOT, linewidth=2.4,
                  markersize=7, markerfacecolor=TARGET_HOT,
                  markeredgecolor="#ffd2b0", markeredgewidth=1.0, label="target")
    ax_dat_b.plot(k, decoy_resp, "-s", color=TEAL_DEEP, linewidth=1.8,
                  markersize=6, markerfacecolor=TEAL_DEEP,
                  markeredgecolor=TEAL, markeredgewidth=0.8, label="decoy")
    ax_dat_b.text(0.05, 1.05, "$K$-dim fingerprint  $\\mathbf{y}_\\mathrm{CR}$",
                  color=TEAL, fontsize=10, weight="bold")
    ax_dat_b.text(0.05, -0.10, "operator index $k$",
                  color=TEXT_DIM, fontsize=8, style="italic")
    leg = ax_dat_b.legend(loc="lower right", frameon=False, fontsize=8.5,
                          labelcolor="linecolor", handlelength=1.5)
    ax_dat_b.add_patch(Rectangle((0.02, -0.13), 5.96, 1.27, facecolor="none",
                                  edgecolor=TEAL_DEEP, linewidth=0.8,
                                  transform=ax_dat_b.transData))

    # ============ WALL — the visual thesis ============
    wall_x = (X_WAL[0] + X_WAL[1]) / 2
    wall_y0 = Y_BOT[0] - 0.025
    wall_y1 = Y_TOP[1] + 0.025
    # multi-layer glow halos
    for w, a in [(0.034, 0.08), (0.022, 0.16), (0.014, 0.30), (0.008, 0.55), (0.004, 0.95)]:
        fig.add_artist(Rectangle((wall_x - w / 2, wall_y0),
                                  w, wall_y1 - wall_y0,
                                  facecolor=WALL_GLOW, alpha=a, edgecolor="none",
                                  transform=fig.transFigure, zorder=5))
    # ADC label at top of the wall
    fig.text(wall_x, 0.840, "ADC", color=WALL_GLOW, ha="center",
             fontsize=12, weight="bold", zorder=6)
    fig.text(wall_x, 0.825, "digitization", color=WALL_GLOW, ha="center",
             fontsize=7.5, style="italic", zorder=6)
    # vertical text along the wall (between the two tracks)
    fig.text(wall_x + 0.018, (Y_BOT[1] + Y_TOP[0]) / 2,
             "photons  ↦  bits",
             color=WALL_GLOW, fontsize=9, rotation=90,
             ha="center", va="center", weight="bold", alpha=0.95, zorder=6)

    # ============ OUTCOMES ============
    ax_out_t = fig.add_axes([X_OUT[0], Y_TOP[0], X_OUT[1] - X_OUT[0], Y_TOP[1] - Y_TOP[0]])
    ax_out_t.set_xlim(0, 1); ax_out_t.set_ylim(0, 1); ax_out_t.set_facecolor("none")
    ax_out_t.set_xticks([]); ax_out_t.set_yticks([])
    for sp in ax_out_t.spines.values():
        sp.set_visible(False)
    # algorithm block
    ax_out_t.add_patch(FancyBboxPatch((0.04, 0.42), 0.30, 0.30,
                                       boxstyle="round,pad=0.01,rounding_size=0.04",
                                       facecolor=DEAD_GRAY_D, edgecolor=DEAD_GRAY,
                                       linewidth=1.0))
    ax_out_t.text(0.19, 0.57, "backend\nalgorithm", color=TEXT_DIM, ha="center",
                  va="center", fontsize=9.5, weight="bold")
    # decision arrow
    ax_out_t.add_patch(FancyArrowPatch((0.36, 0.57), (0.58, 0.57),
                                        arrowstyle="-|>", mutation_scale=18,
                                        color=DEAD_GRAY, linewidth=1.6))
    # FAIL box
    ax_out_t.add_patch(FancyBboxPatch((0.60, 0.40), 0.36, 0.36,
                                       boxstyle="round,pad=0.01,rounding_size=0.04",
                                       facecolor="#2a1518", edgecolor=RED_FAIL,
                                       linewidth=1.6))
    ax_out_t.text(0.78, 0.65, "FAIL", color=RED_FAIL, ha="center",
                  fontsize=18, weight="bold")
    ax_out_t.text(0.78, 0.50, "target indistinguishable", color=RED_FAIL,
                  ha="center", fontsize=8.5)
    ax_out_t.text(0.50, 0.20,
                  "info lost in the optical-to-digital crossing",
                  color=TEXT_DIM, ha="center", fontsize=9, style="italic")

    ax_out_b = fig.add_axes([X_OUT[0], Y_BOT[0], X_OUT[1] - X_OUT[0], Y_BOT[1] - Y_BOT[0]])
    ax_out_b.set_xlim(0, 1); ax_out_b.set_ylim(0, 1); ax_out_b.set_facecolor("none")
    ax_out_b.set_xticks([]); ax_out_b.set_yticks([])
    for sp in ax_out_b.spines.values():
        sp.set_visible(False)
    ax_out_b.add_patch(FancyBboxPatch((0.04, 0.42), 0.30, 0.30,
                                       boxstyle="round,pad=0.01,rounding_size=0.04",
                                       facecolor="#0d2425", edgecolor=TEAL,
                                       linewidth=1.2))
    ax_out_b.text(0.19, 0.62, "simple", color=TEAL, ha="center", fontsize=10, weight="bold")
    ax_out_b.text(0.19, 0.50, "threshold", color=TEAL, ha="center", fontsize=10, weight="bold")
    ax_out_b.add_patch(FancyArrowPatch((0.36, 0.57), (0.58, 0.57),
                                        arrowstyle="-|>", mutation_scale=20,
                                        color=TEAL, linewidth=1.8))
    ax_out_b.add_patch(FancyBboxPatch((0.60, 0.40), 0.36, 0.36,
                                       boxstyle="round,pad=0.01,rounding_size=0.04",
                                       facecolor="#0d2a1a", edgecolor=GREEN_OK,
                                       linewidth=1.6))
    ax_out_b.text(0.78, 0.65, "TARGET", color=GREEN_OK, ha="center",
                  fontsize=17, weight="bold")
    ax_out_b.text(0.78, 0.50, "decoy rejected", color=GREEN_OK,
                  ha="center", fontsize=8.5)
    ax_out_b.text(0.50, 0.20,
                  "discrimination already accomplished optically",
                  color=TEAL, ha="center", fontsize=9, style="italic")

    # ============ FLOW ARROWS BETWEEN COLUMNS ============
    arrow_kw = dict(arrowstyle="-|>", mutation_scale=15, linewidth=1.3)
    # top track scene -> optics
    fig.add_artist(FancyArrowPatch((X_SCN[1] + 0.001, (Y_TOP[0] + Y_TOP[1]) / 2),
                                    (X_OPT[0] - 0.001, (Y_TOP[0] + Y_TOP[1]) / 2),
                                    transform=fig.transFigure, color=DEAD_GRAY, **arrow_kw))
    # top track optics -> data
    fig.add_artist(FancyArrowPatch((X_OPT[1] + 0.001, (Y_TOP[0] + Y_TOP[1]) / 2),
                                    (X_DAT[0] - 0.001, (Y_TOP[0] + Y_TOP[1]) / 2),
                                    transform=fig.transFigure, color=DEAD_GRAY, **arrow_kw))
    # top track data -> wall
    fig.add_artist(FancyArrowPatch((X_DAT[1] + 0.001, (Y_TOP[0] + Y_TOP[1]) / 2),
                                    (X_WAL[0] - 0.001, (Y_TOP[0] + Y_TOP[1]) / 2),
                                    transform=fig.transFigure, color=DEAD_GRAY, **arrow_kw))
    # bottom track scene -> optics
    fig.add_artist(FancyArrowPatch((X_SCN[1] + 0.001, (Y_BOT[0] + Y_BOT[1]) / 2),
                                    (X_OPT[0] - 0.001, (Y_BOT[0] + Y_BOT[1]) / 2),
                                    transform=fig.transFigure, color=TEAL,
                                    linewidth=1.6, arrowstyle="-|>", mutation_scale=18))
    fig.add_artist(FancyArrowPatch((X_OPT[1] + 0.001, (Y_BOT[0] + Y_BOT[1]) / 2),
                                    (X_DAT[0] - 0.001, (Y_BOT[0] + Y_BOT[1]) / 2),
                                    transform=fig.transFigure, color=TEAL,
                                    linewidth=1.6, arrowstyle="-|>", mutation_scale=18))
    fig.add_artist(FancyArrowPatch((X_DAT[1] + 0.001, (Y_BOT[0] + Y_BOT[1]) / 2),
                                    (X_WAL[0] - 0.001, (Y_BOT[0] + Y_BOT[1]) / 2),
                                    transform=fig.transFigure, color=TEAL,
                                    linewidth=1.6, arrowstyle="-|>", mutation_scale=18))

    # ============ FOOTER LINE ============
    fig.text(0.5, 0.025,
             "Photons cross the digitization wall only after being interrogated by a calibrated, mission-tuned optical operator family",
             color=TEXT_DIM, fontsize=10, ha="center", style="italic")

    # ============ SAVE ============
    print(f"Saving {OUT_PNG} ...")
    fig.savefig(str(OUT_PNG), dpi=DPI, facecolor=BG, bbox_inches=None, pad_inches=0)
    print(f"  ({OUT_PNG.stat().st_size / 1e6:.2f} MB)")
    print(f"Saving {OUT_SVG} ...")
    fig.savefig(str(OUT_SVG), facecolor=BG, bbox_inches=None, pad_inches=0)
    print(f"  ({OUT_SVG.stat().st_size / 1e6:.2f} MB)")


if __name__ == "__main__":
    main()
