---
layout: default
title: Model.FromFile
description: Loads a list of mesh and material subsets from a .obj, .stl, .ply (ASCII), .gltf, or .glb file.
---
# [Model]({{site.url}}/Pages/Reference/Model.html).FromFile

<div class='signature' markdown='1'>
static [Model]({{site.url}}/Pages/Reference/Model.html) FromFile(string file, [Shader]({{site.url}}/Pages/Reference/Shader.html) shader)
</div>

|  |  |
|--|--|
|string file|Name of the file to load! This gets prefixed             with the StereoKit asset folder if no drive letter is specified             in the path.|
|[Shader]({{site.url}}/Pages/Reference/Shader.html) shader|The shader to use for the model's materials!             If null, this will             automatically determine the best shader available to use.|
|RETURNS: [Model]({{site.url}}/Pages/Reference/Model.html)|A Model created from the file, or null if the file failed to load!|

Loads a list of mesh and material subsets from a .obj,
.stl, .ply (ASCII), .gltf, or .glb file.




## Examples

### Loading an animated Model
Here, we're loading a Model that we know has the animations "Idle"
and "Jump". This sample shows some options, but only a single call
to PlayAnim is necessary to start an animation.
```csharp
Model model = Model.FromFile("Cosmonaut.glb");

// You can look at the model's animations:
foreach (Anim anim in model.Anims)
	Log.Info($"Animation: {anim.Name} {anim.Duration}s");

// You can play an animation like this
model.PlayAnim("Jump", AnimMode.Once);

// Or you can find and store the animations in advance
Anim jumpAnim = model.FindAnim("Idle");
if (jumpAnim != null)
	model.PlayAnim(jumpAnim, AnimMode.Loop);
```

