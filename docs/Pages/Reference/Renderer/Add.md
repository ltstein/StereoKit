---
layout: default
title: Renderer.Add
description: Adds a mesh to the render queue for this frame! If the Hierarchy has a transform on it, that transform is combined with the Matrix provided here.
---
# [Renderer]({{site.url}}/Pages/Reference/Renderer.html).Add

<div class='signature' markdown='1'>
static void Add([Mesh]({{site.url}}/Pages/Reference/Mesh.html) mesh, [Material]({{site.url}}/Pages/Reference/Material.html) material, [Matrix]({{site.url}}/Pages/Reference/Matrix.html) transform)
</div>

|  |  |
|--|--|
|[Mesh]({{site.url}}/Pages/Reference/Mesh.html) mesh|A valid Mesh you wish to draw.|
|[Material]({{site.url}}/Pages/Reference/Material.html) material|A Material to apply to the Mesh.|
|[Matrix]({{site.url}}/Pages/Reference/Matrix.html) transform|A Matrix that will transform the mesh             from Model Space into the current Hierarchy Space.|

Adds a mesh to the render queue for this frame! If the
Hierarchy has a transform on it, that transform is combined with
the Matrix provided here.
<div class='signature' markdown='1'>
static void Add([Mesh]({{site.url}}/Pages/Reference/Mesh.html) mesh, [Material]({{site.url}}/Pages/Reference/Material.html) material, [Matrix]({{site.url}}/Pages/Reference/Matrix.html) transform, [Color]({{site.url}}/Pages/Reference/Color.html) colorLinear, RenderLayer layer)
</div>

|  |  |
|--|--|
|[Mesh]({{site.url}}/Pages/Reference/Mesh.html) mesh|A valid Mesh you wish to draw.|
|[Material]({{site.url}}/Pages/Reference/Material.html) material|A Material to apply to the Mesh.|
|[Matrix]({{site.url}}/Pages/Reference/Matrix.html) transform|A Matrix that will transform the mesh             from Model Space into the current Hierarchy Space.|
|[Color]({{site.url}}/Pages/Reference/Color.html) colorLinear|A per-instance linear space color value             to pass into the shader! Normally this gets used like a material             tint. If you're  adventurous and don't need per-instance colors,             this is a great spot to pack in extra per-instance data for the             shader!|
|RenderLayer layer|All visuals are rendered using a layer              bit-flag. By default, all layers are rendered, but this can be              useful for filtering out objects for different rendering              purposes! For example: rendering a mesh over the user's head from             a 3rd person perspective, but filtering it out from the 1st             person perspective.|

Adds a mesh to the render queue for this frame! If the
Hierarchy has a transform on it, that transform is combined with
the Matrix provided here.
<div class='signature' markdown='1'>
static void Add([Model]({{site.url}}/Pages/Reference/Model.html) model, [Matrix]({{site.url}}/Pages/Reference/Matrix.html) transform)
</div>

|  |  |
|--|--|
|[Model]({{site.url}}/Pages/Reference/Model.html) model|A valid Model you wish to draw.|
|[Matrix]({{site.url}}/Pages/Reference/Matrix.html) transform|A Matrix that will transform the Model             from Model Space into the current Hierarchy Space.|

Adds a Model to the render queue for this frame! If the
Hierarchy has a transform on it, that transform is combined with
the Matrix provided here.
<div class='signature' markdown='1'>
static void Add([Model]({{site.url}}/Pages/Reference/Model.html) model, [Matrix]({{site.url}}/Pages/Reference/Matrix.html) transform, [Color]({{site.url}}/Pages/Reference/Color.html) colorLinear, RenderLayer layer)
</div>

|  |  |
|--|--|
|[Model]({{site.url}}/Pages/Reference/Model.html) model|A valid Model you wish to draw.|
|[Matrix]({{site.url}}/Pages/Reference/Matrix.html) transform|A Matrix that will transform the Model             from Model Space into the current Hierarchy Space.|
|[Color]({{site.url}}/Pages/Reference/Color.html) colorLinear|A per-instance linear space color value             to pass into the shader! Normally this gets used like a material             tint. If you're  adventurous and don't need per-instance colors,             this is a great spot to pack in extra per-instance data for the             shader!|
|RenderLayer layer|All visuals are rendered using a layer              bit-flag. By default, all layers are rendered, but this can be              useful for filtering out objects for different rendering              purposes! For example: rendering a mesh over the user's head from             a 3rd person perspective, but filtering it out from the 1st             person perspective.|

Adds a Model to the render queue for this frame! If the
Hierarchy has a transform on it, that transform is combined with
the Matrix provided here.



