---
layout: default
title: Quat
description: Quaternions are efficient and robust mathematical objects for representing rotations! Understanding the details of how a quaterion works is not generally necessary for using them effectively, so don't worry too much if they seem weird to you. They're weird to me too.  If you're interested in learning the details though, 3Blue1Brown and Ben Eater have an [excellent interactive lesson](https.//eater.net/quaternions) about them!
---
# struct Quat

Quaternions are efficient and robust mathematical objects
for representing rotations! Understanding the details of how a
quaterion works is not generally necessary for using them
effectively, so don't worry too much if they seem weird to you.
They're weird to me too.

If you're interested in learning the details though, 3Blue1Brown and
Ben Eater have an [excellent interactive lesson](https://eater.net/quaternions)
about them!


## Instance Fields and Properties

|  |  |
|--|--|
|[Quat]({{site.url}}/Pages/Reference/Quat.html) [Inverse]({{site.url}}/Pages/Reference/Quat/Inverse.html)|The reverse rotation! If this quat goes from A to B, the inverse will go from B to A.|
|[Quat]({{site.url}}/Pages/Reference/Quat.html) [Normalized]({{site.url}}/Pages/Reference/Quat/Normalized.html)|A normalized quaternion has the same orientation, and a length of 1.|
|Quaternion [q]({{site.url}}/Pages/Reference/Quat/q.html)|The internal, wrapped System.Numerics type. This can be nice to have around so you can pass its fields as 'ref', which you can't do with properties. You won't often need this, as implicit conversions to System.Numerics types are also provided.|
|[Vec4]({{site.url}}/Pages/Reference/Vec4.html) [Vec4]({{site.url}}/Pages/Reference/Quat/Vec4.html)|Sometimes you want to do weird stuff with your Quaternions. I won't judge. This just turns the Quat into a Vec4, makes some types of math easier!|


## Instance Methods

|  |  |
|--|--|
|[Quat]({{site.url}}/Pages/Reference/Quat/Quat.html)|You may want to use static creation methods, like Quat.LookAt, or Quat.Identity instead of this one! Unless you know what you're doing.|
|[Invert]({{site.url}}/Pages/Reference/Quat/Invert.html)|Makes this Quat the reverse rotation! If this quat goes from A to B, the inverse will go from B to A.|
|[Normalize]({{site.url}}/Pages/Reference/Quat/Normalize.html)|A normalized quaternion has the same orientation, and a length of 1.|


## Static Fields and Properties

|  |  |
|--|--|
|[Quat]({{site.url}}/Pages/Reference/Quat.html) [Identity]({{site.url}}/Pages/Reference/Quat/Identity.html)|This is the 'multiply by one!' of the quaternion rotation world. It's basically a default, no rotation quaternion.|


## Static Methods

|  |  |
|--|--|
|[Difference]({{site.url}}/Pages/Reference/Quat/Difference.html)|This gives a relative rotation between the first and second quaternion rotations. Remember that order is important here!|
|[FromAngles]({{site.url}}/Pages/Reference/Quat/FromAngles.html)|Creates a Roll/Pitch/Yaw rotation (applied in that order) from the provided angles in degrees!|
|[LookAt]({{site.url}}/Pages/Reference/Quat/LookAt.html)|Creates a rotation from a resting direction, to a direction indicated by the direction of the two vectors provided to the function! This is a great function for camera style rotation, when you know where a camera is, and where you want to look at. This prevents roll on the Z axis, Up is always (0,1,0)|
|[LookDir]({{site.url}}/Pages/Reference/Quat/LookDir.html)|Creates a rotation from a resting direction, to the given direction! This prevents roll on the Z axis, Up is always (0,1,0)|
|[Slerp]({{site.url}}/Pages/Reference/Quat/Slerp.html)|Spherical Linear intERPolation. Interpolates between two quaternions! Both Quats should be normalized/unit quaternions, or you may get unexpected results.|

