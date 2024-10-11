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

3 、从生成的shp文件里面看到字体的高度为 127

4、以“皞”字为例，在AutoCAD里面利用EXpressTool构造高度为127的皞字，可通过两个字拼等办法。使用 Express –\> Tools -\> Make Shape 构造形文件

5、把上一步构造出的形文件内容复制到sffs.shp文件里面，

6、查找“皞”字对应的编码 （GBK），替换皞字形文件里面的编号（ `*` 后面的数字 ）

7、在AutoCAD里面调用compile命令编译sffs.shp文件生成sffs.shx

8、使用ShxViewer.exe查看生僻字是否存在
