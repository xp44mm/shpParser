shpParser将shp文件解析成结构数据，容易增删改查。
解析后的数据结构为：

```f#
type FileDef =
    {
        title: string
        shapes: ShapeDef list
    }

type ShapeDef =
    {
        shapenumber: int
        rows: string list
    }

```
用法见测试文件： 
```
\TestProject1\ShapeDefsTest.fs
```

如何得到shp文件？

2 、利用shx2shp.exe将SFFS.shx反编译成sffs.shp

```
\shpParser\scale\chin2.shape
\shpParser\scale\chin2.SHP
\shpParser\scale\design.shape
\shpParser\scale\design.SHP
\shpParser\scale\SBHZ.shape
\shpParser\scale\SBHZ.SHP
\shpParser\scale\tssdchn.shape
\shpParser\scale\tssdchn.SHP
\shpParser\scale\XDX.shape
\shpParser\scale\XDX.SHP
```