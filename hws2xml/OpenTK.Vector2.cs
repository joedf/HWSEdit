#region --- License ---
/*
Copyright (c) 2006 - 2008 The Open Toolkit library.

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
of the Software, and to permit persons to whom the Software is furnished to do
so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
 */
#endregion

// THIS IS A BARE-BONES/STRIPPED VERSION OF THE ORIGINAL.
// This way, we don't need to include the whole OpenTK.dll
// We only need Vector2

using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace OpenTK
{
	/// <summary>Represents a 2D vector using two single-precision floating-point numbers.</summary>
	/// <remarks>
	/// The Vector2 structure is suitable for interoperation with unmanaged code requiring two consecutive floats.
	/// </remarks>
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector2 : IEquatable<Vector2>
	{
		#region Fields

		/// <summary>
		/// The X component of the Vector2.
		/// </summary>
		public float X;

		/// <summary>
		/// The Y component of the Vector2.
		/// </summary>
		public float Y;

		#endregion

		#region Constructors

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		/// <param name="value">The value that will initialize this instance.</param>
		public Vector2(float value)
		{
			X = value;
			Y = value;
		}

		/// <summary>
		/// Constructs a new Vector2.
		/// </summary>
		/// <param name="x">The x coordinate of the net Vector2.</param>
		/// <param name="y">The y coordinate of the net Vector2.</param>
		public Vector2(float x, float y)
		{
			X = x;
			Y = y;
		}

		#endregion

		#region IEquatable<Vector2> Members

		/// <summary>Indicates whether the current vector is equal to another vector.</summary>
		/// <param name="other">A vector to compare with this vector.</param>
		/// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
		public bool Equals(Vector2 other)
		{
			return
				X == other.X &&
				Y == other.Y;
		}

		#endregion
	}
}
