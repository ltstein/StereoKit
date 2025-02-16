---
layout: default
title: UI.Input
description: This is an input field where users can input text to the app! Selecting it will spawn a virtual keyboard, or act as the keyboard focus. Hitting escape or enter, or focusing another UI element will remove focus from this Input.
---
# [UI]({{site.url}}/Pages/Reference/UI.html).Input

<div class='signature' markdown='1'>
static bool Input(string id, String& value, [Vec2]({{site.url}}/Pages/Reference/Vec2.html) size)
</div>

|  |  |
|--|--|
|string id|A per-window unique id for tracking element              state.|
|String& value|The string that will store the Input's              content in.|
|[Vec2]({{site.url}}/Pages/Reference/Vec2.html) size|Size of the Input in Hierarchy local meters.             Zero axes will auto-size.|
|RETURNS: bool|Returns true every time the contents of 'value' change.|

This is an input field where users can input text to the
app! Selecting it will spawn a virtual keyboard, or act as the
keyboard focus. Hitting escape or enter, or focusing another UI
element will remove focus from this Input.



