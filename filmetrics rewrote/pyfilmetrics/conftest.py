import os
import sys

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))

# Reference data shipped by FILMeasure (read-only) used for validation tests.
PROGRAMDATA = r"C:\ProgramData\Filmetrics"
RECIPES_DIR = os.path.join(PROGRAMDATA, "FILMeasure", "Recipes")
MATERIAL_DIR = os.path.join(PROGRAMDATA, "FILMeasure", "Material")
PRECISION_DIR = os.path.join(PROGRAMDATA, "Precision")
