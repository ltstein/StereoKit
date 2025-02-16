---
layout: default
title: Mesh.GeneratePlane
description: Generates a plane on the XZ axis facing up that is optionally subdivided, pre-sized to the given dimensions. UV coordinates start at 0,0 at the -X,-Z corer, and go to 1,1 at the +X,+Z corner!
---
# [Mesh]({{site.url}}/Pages/Reference/Mesh.html).GeneratePlane

<div class='signature' markdown='1'>
static [Mesh]({{site.url}}/Pages/Reference/Mesh.html) GeneratePlane([Vec2]({{site.url}}/Pages/Reference/Vec2.html) dimensions, int subdivisions)
</div>

|  |  |
|--|--|
|[Vec2]({{site.url}}/Pages/Reference/Vec2.html) dimensions|How large is this plane on the XZ axis,             in meters?|
|int subdivisions|Use this to add extra slices of              vertices across the plane. This can be useful for some types of             vertex-based effects!|
|RETURNS: [Mesh]({{site.url}}/Pages/Reference/Mesh.html)|A plane mesh, pre-sized to the given dimensions.|

Generates a plane on the XZ axis facing up that is
optionally subdivided, pre-sized to the given dimensions. UV
coordinates start at 0,0 at the -X,-Z corer, and go to 1,1 at the
+X,+Z corner!
<div class='signature' markdown='1'>
static [Mesh]({{site.url}}/Pages/Reference/Mesh.html) GeneratePlane([Vec2]({{site.url}}/Pages/Reference/Vec2.html) dimensions, [Vec3]({{site.url}}/Pages/Reference/Vec3.html) planeNormal, [Vec3]({{site.url}}/Pages/Reference/Vec3.html) planeTopDirection, int subdivisions)
</div>

|  |  |
|--|--|
|[Vec2]({{site.url}}/Pages/Reference/Vec2.html) dimensions|How large is this plane on the XZ axis,              in meters?|
|[Vec3]({{site.url}}/Pages/Reference/Vec3.html) planeNormal|What is the normal of the surface this             plane is generated on?|
|[Vec3]({{site.url}}/Pages/Reference/Vec3.html) planeTopDirection|A normal defines the plane, but              this is technically a rectangle on the              plane. So which direction is up? It's important for UVs, but              doesn't need to be exact. This function takes the planeNormal as             law, and uses this vector to find the right and up vectors via             cross-products.|
|int subdivisions|Use this to add extra slices of              vertices across the plane. This can be useful for some types of             vertex-based effects!|
|RETURNS: [Mesh]({{site.url}}/Pages/Reference/Mesh.html)|A plane mesh, pre-sized to the given dimensions.|

Generates a plane with an arbitrary orientation that is
optionally subdivided, pre-sized to the given dimensions. UV
coordinates start at the top left indicated with
'planeTopDirection'.




## Examples

![Procedural Geometry Demo]({{site.url}}/img/screenshots/ProceduralGeometry.jpg)
Here's a quick example of generating a mesh! You can store it in just a
Mesh, or you can attach it to a Model for easier rendering later on.
```csharp
Mesh  planeMesh  = Mesh.GeneratePlane(Vec2.One*0.4f);
Model planeModel = Model.FromMesh(planeMesh, Default.Material);
```
Drawing both a Mesh and a Model generated this way is reasonably simple,
here's a short example! For the Mesh, you'll need to create your own material,
we just loaded up the default Material here.
```csharp
Matrix planeTransform = Matrix.T(-.5f, -1, 0);
Renderer.Add(planeMesh, Default.Material, planeTransform);

planeTransform = Matrix.T(.5f, -1, 0);
Renderer.Add(planeModel, planeTransform);
```
## UV and Face layout
Here's a test image that illustrates how this mesh's geometry is
laid out.
![Procedural Cube Mesh]({{site.screen_url}}/ProcGeoPlane.jpg)
```csharp
meshPlane = Mesh.GeneratePlane(Vec2.One);
```

