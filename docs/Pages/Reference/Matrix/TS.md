---
layout: default
title: Matrix.TS
description: Translate, Scale. Creates a transform Matrix using both these components!
---
# [Matrix]({{site.url}}/Pages/Reference/Matrix.html).TS

<div class='signature' markdown='1'>
static [Matrix]({{site.url}}/Pages/Reference/Matrix.html) TS([Vec3]({{site.url}}/Pages/Reference/Vec3.html) translation, float scale)
</div>

|  |  |
|--|--|
|[Vec3]({{site.url}}/Pages/Reference/Vec3.html) translation|Move an object by this amount.|
|float scale|How much larger or smaller this transform             makes things. 1 is a good default, as 0 will shrink it to nothing!             This will expand to a scale vector of (size, size, size)|
|RETURNS: [Matrix]({{site.url}}/Pages/Reference/Matrix.html)|A Matrix that combines translation and scale information into a single Matrix!|

Translate, Scale. Creates a transform Matrix using both
these components!
<div class='signature' markdown='1'>
static [Matrix]({{site.url}}/Pages/Reference/Matrix.html) TS([Vec3]({{site.url}}/Pages/Reference/Vec3.html) translation, [Vec3]({{site.url}}/Pages/Reference/Vec3.html) scale)
</div>

|  |  |
|--|--|
|[Vec3]({{site.url}}/Pages/Reference/Vec3.html) translation|Move an object by this amount.|
|[Vec3]({{site.url}}/Pages/Reference/Vec3.html) scale|How much larger or smaller this transform              makes things. Vec3.One is a good default, as Vec3.Zero will              shrink it to nothing!|
|RETURNS: [Matrix]({{site.url}}/Pages/Reference/Matrix.html)|A Matrix that combines translation and scale information into a single Matrix!|

Translate, Scale. Creates a transform Matrix using both
these components!
<div class='signature' markdown='1'>
static [Matrix]({{site.url}}/Pages/Reference/Matrix.html) TS(float x, float y, float z, float scale)
</div>

|  |  |
|--|--|
|float x|Move an object on the x axis by this amount.|
|float y|Move an object on the y axis by this amount.|
|float z|Move an object on the z axis by this amount.|
|float scale|How much larger or smaller this transform              makes things. Vec3.One is a good default, as Vec3.Zero will              shrink it to nothing!|
|RETURNS: [Matrix]({{site.url}}/Pages/Reference/Matrix.html)|A Matrix that combines translation and scale information into a single Matrix!|

Translate, Scale. Creates a transform Matrix using both
these components!
<div class='signature' markdown='1'>
static [Matrix]({{site.url}}/Pages/Reference/Matrix.html) TS(float x, float y, float z, [Vec3]({{site.url}}/Pages/Reference/Vec3.html) scale)
</div>

|  |  |
|--|--|
|float x|Move an object on the x axis by this amount.|
|float y|Move an object on the y axis by this amount.|
|float z|Move an object on the z axis by this amount.|
|[Vec3]({{site.url}}/Pages/Reference/Vec3.html) scale|How much larger or smaller this transform              makes things. Vec3.One is a good default, as Vec3.Zero will              shrink it to nothing!|
|RETURNS: [Matrix]({{site.url}}/Pages/Reference/Matrix.html)|A Matrix that combines translation and scale information into a single Matrix!|

Translate, Scale. Creates a transform Matrix using both
these components!



