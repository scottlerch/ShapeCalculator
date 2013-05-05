//-----------------------------------------------------------------------
// <copyright file="Point.cs" company="N/A">
//     Copyright Scott Lerch. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ShapeLibrary
{
    using System;
    using System.Globalization;

    /// <summary>
    /// Point struct using double as the underlying data type.
    /// </summary>
    public struct Point : IEquatable<Point>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> struct.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        public Point(double x, double y) : this()
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets the X coordinate.
        /// </summary>
        public double X { get; private set; }

        /// <summary>
        /// Gets the Y coordinate.
        /// </summary>
        public double Y { get; private set; }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="point1">The point 1.</param>
        /// <param name="point2">The point 2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(Point point1, Point point2)
        {
            return point1.Equals(point2);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="point1">The point 1.</param>
        /// <param name="point2">The point 2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(Point point1, Point point2)
        {
            return !point1.Equals(point2);
        }   

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "{X={0},Y={1}", this.X, this.Y);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is 
        /// equal to this instance.
        /// </summary>
        /// <param name="obj">
        /// The <see cref="System.Object"/> to compare with this instance.
        /// </param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="System.Object"/> is equal to
        /// this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is Point)
            {
                return this.Equals((Point)obj);
            }

            return false;
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of 
        /// the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> 
        /// parameter; otherwise, false.
        /// </returns>
        public bool Equals(Point other)
        {
            return this.X.Equals(other.X) && this.Y.Equals(other.Y);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing
        /// algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        { 
            unchecked
            {
                int hash = 17;
                hash = (hash * 23) + this.X.GetHashCode();
                hash = (hash * 23) + this.Y.GetHashCode();
                return hash;
            }
        }
    }
}
