# About Shape Descriptions

Font and shape files (SHX) are compiled from shape definition files (SHP). You can create or modify shape definition files with a text editor or word processor that saves files in ASCII format.

The syntax of the shape description for each shape or character is the same regardless of the final use (shape or font) for that shape description. If a shape definition file is to be used as a font file, the first entry in the file describes the font itself rather than a shape within the file. If this initial entry describes a shape, the file is used as a shape file.

Each line in a shape definition file can contain up to 128 characters. Longer lines cannot be compiled. Because the program ignores blank lines and text to the right of a semicolon, you can embed comments in shape definition files.

Each shape description has a header line of the following form and is followed by one or more lines containing specification bytes, separated by commas and terminated by a 0.

```
*shapenumber,defbytes,shapename
specbyte1,specbyte2,specbyte3,...,0
```

The following list describes the fields of a shape description:

- shapenumber

  A number, unique to the file, between 1 and 258 (and up to 32768 for Unicode fonts), and preceded by an asterisk (*). Non-Unicode font files use the shape numbers 256, 257, and 258 for the symbolic identifiers Degree_Sign, Plus_Or_Minus_Sign, and Diameter_Symbol. For Unicode fonts these glyphs appear at the U+00B0, U+00B1, and U+2205 shape numbers and are part of the “Latin Extended-A” subset.Text fonts (files containing shape definitions for each character) require specific numbers corresponding to the value of each character in the ASCII code; other shapes can be assigned any numbers.

- defbytes

  The number of data bytes ( *specbytes* ) required to describe the shape, including the terminating 0. The limit is 2,000 bytes per shape.

- shapename

  The shape name. Shape names must be uppercase to be recognized. Names with lowercase characters are ignored and are usually used to label font shape definitions.

- specbyte

  A shape specification byte. Each specification byte is a code that defines either a vector length and direction or one of a number of special codes. A specification byte can be expressed in the shape definition file as either a decimal or hexadecimal value. If the first character of a specification byte is a 0 (zero), the two characters that follow are interpreted as hexadecimal values.

# About Vector Length and Direction Codes

A simple shape specification byte contains vector length and direction encoded into one specification byte.

Each vector length and direction code is a string of three characters. The first character must be a `0`, which indicates to the program that the next two characters are interpreted as hexadecimal values. The second character specifies the length of the vector in units. Valid hexadecimal values range from 1 (one unit long) through F (15 units long). The third character specifies the direction of the vector. The following figure illustrates the direction codes.

![img](D:\Application Data\GitHub\xp44mm\shpParser\markdown\direction.png)

Vector direction codes

All the vectors in the preceding figure were drawn with the same length specification. Diagonal vectors stretch to match the *X* or *Y* displacement of the closest orthogonal vector.

The following example constructs a shape named DBOX with an arbitrarily assigned shape number of 230.

```
*230,6,DBOX 
014,010,01C,018,012,0
```

The preceding sequence of specification bytes defines a box one unit high by one unit wide, with a diagonal line running from the lower left to the upper right. After saving the file as *dbox.shp*, use the COMPILE command to generate the *dbox.shx* file. Use the LOAD command to load the shape file containing this definition, and then use the SHAPE command as follows:

```
Command: shape
Enter shape name or [?]: dbox
Specify insertion point: 1,1
Specify height <current>: 2
Specify rotation angle <current>: 0
```

The resulting shape is shown in the following illustration.

![img](D:\Application Data\GitHub\xp44mm\shpParser\markdown\dbox.png)

# Special Codes Reference

Special codes can be used to create additional geometric forms and specify certain actions.

The second character of the three-character string (the vector length specification) must be 0, or you can specify the special code number. For example, 008 and 8 are both valid specifications.

Specification byte codes

### 000

End of shape definition

Draw is activated at the start of each shape. When Draw mode is turned on (code 1), the vectors cause lines to be drawn. When Draw mode is turned off (code 2), the vectors move to a new location without drawing. 

### 001 

Activate Draw mode (pen down)

### 002

Deactivate Draw mode (pen up)

### 003

Divide vector lengths by next byte

### 004

Multiply vector lengths by next byte

The height specified with the SHAPE command is initially considered the length of a single orthogonal vector (direction 0, 4, 8, or C). Code 3 divides vector lengths by the next byte. Code 4 multiplies vector lengths by the next byte. Codes 3 and 4 are followed by a specification byte containing an integer scale factor (1 through 255).

If you want the shape height to specify the size of the entire shape, and you use 10 vector lengths to draw it, you can use `3,10` to scale the height specification. The scale factor is cumulative within a shape; that is, multiplying by 2 and again by 6 results in a scale factor of 12. Usually, you should reverse the effect of your scale factors at the end of the shape, especially for subshapes and text font shapes. The program does not reset the scale factor for you.



### 005

Push current location onto stack

### 006

Pop current location from stack

You must pop everything you push. The position stack is only four locations deep. If the stack overflows because of too many pushes or too many missing pops, the following message is displayed when the shape is drawn.

```
Position stack overflow in shape nnn
```

Similarly, if you try to pop more locations than have been pushed onto the stack, the following message is displayed when the shape is drawn.

```
Position stack underflow in shape nnn
```

### 007

Draw subshape number given by next byte

For a non-Unicode font the specification byte following code 7 is a shape number from 1 to 255. For a Unicode font, code 7 is followed by a Unicode shape number from 1 to 65535. Unicode shape numbers should be counted as two bytes.

The shape with that number (in the same shape file) is drawn at this time. Draw mode is not reset for the new shape. When the subshape is complete, drawing the current shape resumes.

### 008

X-Y displacement given by next two bytes

### 009

Multiple X-Y displacements, terminated `(0,0)`

Normal vector specification bytes draw only in the 16 predefined directions, and the longest length is 15. These restrictions help make shape definitions efficient but are sometimes limiting. Code 8 specifies the X-Y displacement given by the next two bytes. Code 8 must be followed by two specification bytes in the format:

```
8,X-displacement,Y-displacement
```

The X-Y displacements can range from -128 to +127. A leading + is optional, and you can use parentheses to improve readability. The following example results in a vector that draws (or moves) 10 units to the left and three units up.

```
8,(-10,3)
```

Following the two displacement specification bytes, the shape returns to Normal Vector mode.

You can use code 9 to draw a sequence of nonstandard vectors. Code 9 specifies any number of X-Y displacement pairs. The code sequence is terminated by a `(0,0)` pair. The following example draws three nonstandard vectors and returns to Normal Vector mode.

```
9,(3,1),(3,2),(2,-3),(0,0)
```

You must terminate the sequence of X-Y displacement pairs with a `(0,0)` pair in order for the program to recognize any Normal Vectors or special codes that follow.



### 00A

Octant arc defined by next two bytes

This is called an octant arc because it spans one or more 45-degree octants, starting and ending on an octant boundary. Octants are numbered counterclockwise from the 3 o'clock position, as shown in the following illustration.

![img](D:\Application Data\GitHub\xp44mm\shpParser\markdown\octantarc.png)


The arc specification is

```
10,radius,(-)0SC
```

The radius can be any value from 1 through 255. The second specification byte indicates the direction of the arc (counterclockwise if positive, and clockwise if negative), its starting octant ( `S` , a value from 0 through 7), and the number of octants it spans ( `C` , a value from 0 through 7, in which 0 equals eight octants, or a full circle). You can use parentheses to improve readability. For example, consider the following fragment of a shape definition:

```
...012,10,(1,-032),01E,...
```

This code draws a one-unit vector up and to the right, a clockwise arc from octant 3 (with a radius of one unit for two octants), and then a one-unit vector down and to the right, as shown in the following illustration.

![img](D:\Application Data\GitHub\xp44mm\shpParser\markdown\octantarc3.png)

### 00B

Fractional arc defined by next five bytes

The definition uses five specification bytes.

```
11,start_offset,end_offset,high_radius,radius,(-)0SC
```

The `start_offset` and `end_offset` represent how far from an octant boundary the arc begins or ends. The `high_radius` represents the most significant eight bits of the radius; the high radius will be `0` unless the radius is greater than 255 units. Multiply the `high_radius` value by 256 and add that value to the radius value to generate an arc radius greater than 255. The radius and ending specification byte are the same as for the octant arc specification (code 00A, described previously).

You determine the start offset by calculating the difference in degrees between the starting octant's boundary (a multiple of 45 degrees) and the start of the arc. Then, you multiply this difference by 256 and divide by 45. If the arc starts on an octant boundary, its start offset is 0.

The end offset is calculated in a similar fashion, but you use the number of degrees from the last octant boundary crossed to the end of the arc. If the arc ends on an octant boundary, its end offset is 0.

For example, a fractional arc from `55` degrees to `95` degrees with a 3 unit radius would be coded as follows:

```
11,(56,28,0,3,012)
```

Here is the explanation:

```
start_offset     = 56 because ((55 - 45) * 256 / 45) = 56
end_offset       = 28 because ((95 - 90) * 256 / 45) = 28
high_radius      = 0  because (radius < 255)
radius           = 3
starting octant  = 1  because arc starts in the 45 degree octant
ending octant    = 2  because arc ends in the 90 degree octant
```

### 00C

Arc defined by X-Y displacement and bulge

### 00D

Multiple bulge-specified arcs

They are similar to codes 8 and 9 in that you can use them to specify X-Y displacements. However, codes 00C and 00D draw arcs by applying a bulge factor to the displacement vector. Code 00C draws one arc segment, while code 00D draws multiple arc segments (polyarcs) until it is terminated by a `(0,0)` displacement.

Code 00C must be followed by three bytes describing the arc:

```
0C,X-displacement,Y-displacement,Bulge
```

Both the X and Y displacement and the bulge, which specifies the curvature of the arc, can range from -127 to +127. If the line segment specified by the displacement has length D, and the perpendicular distance from the midpoint of that segment has height H, the magnitude of the bulge is 

```
((2* H / D) * 127)
```

. The sign is negative if the arc from the current location to the new location is clockwise.

![img](D:\Application Data\GitHub\xp44mm\shpParser\markdown\bulge.png)


A semicircle has bulge 127 (or -127) and is the greatest arc that can be represented as a single-arc segment using these codes (use two consecutive arc segments for larger arcs). A bulge specification of 0 is valid and represents a straight-line segment. However, using code 8 for a straight-line segment saves a byte in the shape description.

The polyarc code (00D, or 13) is followed by 0 or by more arc segment triples, and is terminated by a (0,0) displacement. Note that no bulge is specified after the final displacement. For example, the letter `S` might be defined by the following sequence:

```
13,(0,5,127),(0,5,-127),(0,0)
```

Zero bulge segments are useful within polyarcs to represent straight segments; they are more efficient than terminating the polyarc, inserting one straight segment, and then starting another polyarc.

The number -128 cannot be used in arc segment and polyarc definitions.



### 00E

Process next command only if vertical text

When this special code is encountered in a character definition, the next code is either processed or skipped, depending on orientation. If the orientation is vertical, the next code is processed; if it is horizontal, the next code is skipped.

In horizontal text, the start point for each character is the left end of the baseline. In vertical text, the start point is assumed to be the top center of the character. At the end of each character, a pen-up segment is normally drawn to position to the next character's start point. For horizontal text, it is to the right; for vertical text, it is downward. The special `00E (14)` code is used primarily to adjust for differences in start points and endpoints, permitting the same character shape definition to be used both horizontally and vertically. For instance, the following definition of an uppercase D could be used in either horizontal or vertical text.

```
*68,22,ucd 
2,14,8,(-2, 6),1,030,012,044,016,038,2,010,1,06C,2,050,
14,8,(-4,-3),0
```

![img](D:\Application Data\GitHub\xp44mm\shpParser\markdown\verticaltext.png)

# About Text Font Descriptions

Text fonts are files of shape definitions with shape numbers corresponding to an ASCII code for each character.

Codes 1 through 31 are for control characters, only one of which is used in a text font:

- 10 (LF)

  The line feed (LF) must drop down one line without drawing. This is used for repeated TEXT commands, to place succeeding lines below the first one.

  ```
  *10,5,lf
  2,8,(0,-10),0
  ```

  You can modify the spacing of lines by adjusting the downward movement specified by the LF shape definition.

Text fonts must include a special shape number 0 that conveys information about the font itself. The format has the following syntax:

```
*0,4,font-name
above,below,modes,0
```

The *above* value specifies the number of vector lengths above the baseline that the uppercase letters extend, and *below* indicates how far the lowercase letters descend below the baseline. The baseline is similar in concept to the lines on writing paper. These values define the basic character size and are used as scale factors for the height specified for the text object.

The *modes* byte should be 0 for a horizontally oriented font and 2 for a dual-orientation (horizontal or vertical) font. The special 00E (14) command code is honored only when *modes* is set to 2.

The standard fonts supplied with the program include a few additional characters required for dimensioning.

**%%d** Degree symbol (°)

**%%p** Plus/minus tolerance symbol (±)

**%%c** Circle diameter dimensioning symbol

You can use these and other %%*nnn* control sequences to specify a character.

**Note:** The program draws text characters by their ASCII codes (shape numbers) and not by name. To save memory, specify the shape name portion of each text shape definition in lowercase as shown in the following example. (Lowercase names are not saved in memory.)

```
*65,11,uca
024,043,04d,02c,2,047,1,040,2,02e,0
```

Because the shape name *uca* contains lowercase letters, the program does not save the name in memory. However, you can use the name for reference when editing the font definition file. In this example, *uca* stands for uppercase A.
