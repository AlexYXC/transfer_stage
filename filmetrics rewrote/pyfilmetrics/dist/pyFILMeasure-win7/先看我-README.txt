pyFILMeasure —— Windows 7 离线版（32 位，解压即用）
====================================================

怎么用
------
1) 把整个 "pyFILMeasure-win7" 文件夹拷到 Win7 电脑（U 盘即可）。
   ★ 必须整个文件夹一起拷 —— exe 依赖同目录里的其它文件。
2) 双击  pyFILMeasure-win7.exe  就能打开，不用装 Python 或任何东西。
3) 界面里：
   - 点 "Load…" 选一个配方（本文件夹的 sample_recipes\ 里有几个；
     如果这台机器装了 FILMeasure，也会自动读它的 C:\ProgramData\Filmetrics\... 配方）
   - 点 "Take Baseline"（取基线）
   - 点 "Measure"（测量）
   就能看到测量曲线 + 拟合膜厚 + GOF。
   现在是【模拟器】模式：没接仪器也能把整个流程跑通。

自检（可选）
------------
命令行里跑一下会打印结果后退出，用来确认没问题：
   pyFILMeasure-win7.exe --selftest
应显示类似：SELFTEST OK: Thickness: 9001 A   GOF: 0.94...

万一双击报错
------------
若提示缺少 "api-ms-win-crt-...dll" 或 "ucrtbase.dll"：
  说明这台 Win7 缺 "通用 C 运行库(UCRT)"。装一下微软补丁 KB2999226 即可
  （x86 版）。注意：能正常运行 FILMeasure 的机器基本都已经有，通常不会遇到。

连真机（以后）
--------------
这个包是 32 位的，已为连接仪器做好准备（FIUsbInt.dll 是 32 位）。
真机后端我先没默认打开——等你按 HARDWARE_VALIDATION.md 跑通只读验证后，
我再把界面的"真机"开关接上（很小的改动）。

版本
----
Python 3.8 (32-bit) + Tkinter，numpy 1.24.4 / scipy 1.9.1 / matplotlib 3.7.5，
PyInstaller 5.13.2 打包。适用于 Windows 7 SP1 及以上（32/64 位均可）。
