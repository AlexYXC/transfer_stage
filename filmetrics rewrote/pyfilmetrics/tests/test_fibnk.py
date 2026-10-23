import os

import pytest

from filmeas.io.fibnk import FibnkProtectedError, read_header, load_nk

MAT = r"C:\ProgramData\Filmetrics\FILMeasure\Material"

pytestmark = pytest.mark.skipif(not os.path.isdir(MAT), reason="FILMeasure materials not installed")


def test_header_num_points():
    h = read_header(os.path.join(MAT, "Si.fibnk"))
    assert h.num_points == 538
    assert h.version in (3, 4)
    h2 = read_header(os.path.join(MAT, "SiO2.fibnk"))
    assert h2.num_points == 27


def test_payload_is_protected():
    with pytest.raises(FibnkProtectedError):
        load_nk(os.path.join(MAT, "Si.fibnk"))
