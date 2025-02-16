using System.Numerics;
using System.Runtime.CompilerServices;

namespace StereoKit
{
	/// <summary>Quaternions are efficient and robust mathematical objects 
	/// for representing rotations! Understanding the details of how a 
	/// quaterion works is not generally necessary for using them 
	/// effectively, so don't worry too much if they seem weird to you.
	/// They're weird to me too.
	/// 
	/// If you're interested in learning the details though, 3Blue1Brown and
	/// Ben Eater have an [excellent interactive lesson](https://eater.net/quaternions)
	/// about them!</summary>
	public struct Quat
	{
		/// <summary>The internal, wrapped System.Numerics type. This can be
		/// nice to have around so you can pass its fields as 'ref', which
		/// you can't do with properties. You won't often need this, as
		/// implicit conversions to System.Numerics types are also
		/// provided.</summary>
		public Quaternion q;
		public float x { get => q.X; set => q.X = value; }
		public float y { get => q.Y; set => q.Y = value; }
		public float z { get => q.Z; set => q.Z = value; }
		public float w { get => q.W; set => q.W = value; }

		/// <summary>Sometimes you want to do weird stuff with your
		/// Quaternions. I won't judge. This just turns the Quat into a Vec4,
		/// makes some types of math easier!</summary>
		public Vec4 Vec4 => new Vec4(x, y, z, w);

		/// <summary>You may want to use static creation methods, like
		/// Quat.LookAt, or Quat.Identity instead of this one! Unless you
		/// know what you're doing.</summary>
		/// <param name="x">X component of the Quat.</param>
		/// <param name="y">Y component of the Quat.</param>
		/// <param name="z">Z component of the Quat.</param>
		/// <param name="w">W component of the Quat.</param>
		public Quat(float x, float y, float z, float w) 
			=> q = new Quaternion(x,y,z,w);

		public static implicit operator Quat(Quaternion q) => new Quat(q.X, q.Y, q.Z, q.W);
		public static implicit operator Quaternion(Quat q) => q.q;

		public static Quat operator -(Quat a,  Quat b ) => NativeAPI.quat_difference(a, b);
		public static Quat operator *(Quat a,  Quat b ) => Quaternion.Multiply(a, b);
		public static Vec3 operator *(Quat a,  Vec3 pt) => Vector3.Transform(pt, a.q);
		public static Vec3 operator *(Vec3 pt, Quat a ) => Vector3.Transform(pt, a.q);

		/// <summary>This is the 'multiply by one!' of the quaternion
		/// rotation world. It's basically a default, no rotation quaternion.
		/// </summary>
		public static readonly Quat Identity = Quaternion.Identity;

		/// <summary>A normalized quaternion has the same orientation, and a 
		/// length of 1.</summary>
		public Quat Normalized => Quaternion.Normalize(q);

		/// <summary>The reverse rotation! If this quat goes from A to B, the 
		/// inverse will go from B to A.</summary>
		/// <returns>The inverse quaternion.</returns>
		public Quat Inverse => Quaternion.Inverse(q);

		/// <summary>A normalized quaternion has the same orientation, and a 
		/// length of 1.</summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Normalize() => q = Quaternion.Normalize(q);

		/// <summary>Makes this Quat the reverse rotation! If this quat goes
		/// from A to B, the inverse will go from B to A.</summary>
		/// <returns>The inverse quaternion.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Invert() => q = Quaternion.Inverse(q);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Vec3 Rotate(Vec3 pt) => Vector3.Transform(pt, q);

		/// <summary>Creates a rotation from a resting direction, to a
		/// direction indicated by the direction of the two vectors provided
		/// to the function! This is a great function for camera style
		/// rotation, when you know where a camera is, and where you want to
		/// look at. This prevents roll on the Z axis, Up is always (0,1,0)
		/// </summary>
		/// <param name="from">Where the object is.</param>
		/// <param name="to">Where the object should be looking!</param>
		/// <param name="up">Which direction is up from this perspective?
		/// </param>
		/// <returns>A rotation from resting, to the look direction of the 
		/// parameters.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quat LookAt(Vec3 from, Vec3 to, Vec3 up) 
			=> NativeAPI.quat_lookat_up(from, to, up);

		/// <summary>Creates a rotation from a resting direction, to a
		/// direction indicated by the direction of the two vectors provided
		/// to the function! This is a greatfunction for camera style
		/// rotation, when you know where a camera is, and where you want to
		/// look at. This prevents roll on the Z axis, Up is always (0,1,0).
		/// </summary>
		/// <param name="from">Where the object is.</param>
		/// <param name="to">Where the object should be looking!</param>
		/// <returns>A rotation from resting, to the look direction of the
		/// parameters.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quat LookAt(Vec3 from, Vec3 to) 
			=> NativeAPI.quat_lookat_up(from, to, Vec3.Up);

		/// <summary>Creates a rotation from a resting direction, to the
		/// given direction! This prevents roll on the Z axis, Up is always
		/// (0,1,0)</summary>
		/// <param name="direction">Direction the rotation should be looking.
		/// Doesn't need to be normalized.</param>
		/// <returns>A rotation from resting, to the given direction.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quat LookDir(Vec3 direction) 
			=> NativeAPI.quat_lookat(Vec3.Zero, direction);

		/// <summary>Creates a rotation from a resting direction, to the
		/// given direction! This prevents roll on the Z axis, Up is always
		/// (0,1,0)</summary>
		/// <param name="x">X component of the direction the rotation should
		/// be looking. Doesn't need to be normalized.</param>
		/// <param name="y">Y component of the direction the rotation should
		/// be looking. Doesn't need to be normalized.</param>
		/// <param name="z">Z component of the direction the rotation should
		/// be looking. Doesn't need to be normalized.</param>
		/// <returns>A rotation from resting, to the given direction.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quat LookDir(float x, float y, float z) 
			=> NativeAPI.quat_lookat(Vec3.Zero, new Vec3(x, y, z));

		/// <summary>This gives a relative rotation between the first and
		/// second quaternion rotations.
		/// Remember that order is important here!</summary>
		/// <param name="a">Starting rotation.</param>
		/// <param name="b">Ending rotation.</param>
		/// <returns>A rotation that will take a point from rotation a, to
		/// rotation b.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quat Difference(Quat a, Quat b) 
			=> NativeAPI.quat_difference(a, b);

		/// <summary>Creates a Roll/Pitch/Yaw rotation (applied in that
		/// order) from the provided angles in degrees!</summary>
		/// <param name="pitchXDeg">Pitch is rotation around the x axis,
		/// measured in degrees.</param>
		/// <param name="yawYDeg">Yaw is rotation around the y axis, measured
		/// in degrees.</param>
		/// <param name="rollZDeg">Roll is rotation around the z axis, 
		/// measured in degrees.</param>
		/// <returns>A quaternion representing the given Roll/Pitch/Yaw 
		/// roatation!</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quat FromAngles(float pitchXDeg, float yawYDeg, float rollZDeg) 
			=> Quaternion.CreateFromYawPitchRoll(yawYDeg * Units.deg2rad, pitchXDeg * Units.deg2rad, rollZDeg * Units.deg2rad);
		/// <summary>Creates a Roll/Pitch/Yaw rotation (applied in that
		/// order) from the provided angles in degrees!</summary>
		/// <param name="pitchYawRollDeg">Pitch, yaw, and roll stored as
		/// X, Y, and Z in this Vector. Angle values are in degrees.</param>
		/// <returns>A quaternion representing the given Roll/Pitch/Yaw 
		/// roatation!</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quat FromAngles(Vec3 pitchYawRollDeg) 
			=> Quaternion.CreateFromYawPitchRoll(pitchYawRollDeg.y * Units.deg2rad, pitchYawRollDeg.x * Units.deg2rad, pitchYawRollDeg.z * Units.deg2rad);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vec3 Rotate(Quat q, Vec3 pt) 
			=> Vector3.Transform(pt, q);

		/// <summary>Spherical Linear intERPolation. Interpolates between two
		/// quaternions! Both Quats should be normalized/unit quaternions, or
		/// you may get unexpected results.</summary>
		/// <param name="a">Start quaternion, should be normalized/unit 
		/// length.</param>
		/// <param name="b">End quaternion, should be normalized/unit length.
		/// </param>
		/// <param name="slerp">The interpolation amount! This'll be a if 0, 
		/// and b if 1. Unclamped.</param>
		/// <returns>A blend between the two quaternions!</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quat Slerp(Quat a, Quat b, float slerp)
			=> Quaternion.Slerp(a,b, slerp);

		public override string ToString()
			=> string.Format("[{0:0.00}, {1:0.00}, {2:0.00}, {3:0.00}]", x, y, z, w);
	}
}
