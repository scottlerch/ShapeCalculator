//-----------------------------------------------------------------------
// <copyright file="Polygon.cs" company="N/A">
//     Copyright Scott Lerch. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ShapeLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Polygon shape class.
    /// </summary>
    public class Polygon : Shape
    {
        /// <summary>
        /// Ordered array of polygon vertices.
        /// </summary>
        private Point[] vertices;

        /// <summary>
        /// Initializes a new instance of the <see cref="Polygon"/> class.
        /// </summary>
        public Polygon()
        {
            this.vertices = new Point[0];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polygon"/> class.
        /// </summary>
        /// <param name="vertices">The vertices.</param>
        public Polygon(params Point[] vertices) 
            : this(vertices as IEnumerable<Point>)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polygon"/> class.
        /// </summary>
        /// <param name="vertices">The vertices.</param>
        /// <exception cref="ArgumentNullException">
        /// Vertices cannot be null.
        /// </exception>
        public Polygon(IEnumerable<Point> vertices) : this()
        {
            if (vertices == null)
            {
                throw new ArgumentNullException("vertices");
            }

            this.vertices = vertices.ToArray();
            this.UpdateArea();
        }

        /// <summary>
        /// Gets a copy of the vertices.
        /// </summary>
        /// <returns>Copy of the vertices.</returns>
        public Point[] GetVertices()
        {
            return this.vertices.Clone() as Point[];
        }

        /// <summary>
        /// Sets the vertices making a copy of the specified array.
        /// The polygon vertices must be clock-wise and not overlap.
        /// </summary>
        /// <param name="vertices">The vertices.</param>
        /// <exception cref="ArgumentNullException">
        /// Vertices cannot be null.
        /// </exception>
        public void SetVertices(Point[] vertices)
        {
            if (vertices == null)
            {
                throw new ArgumentNullException("vertices");
            }

            this.vertices = vertices.Clone() as Point[];
            this.UpdateArea();
        }

        /// <summary>
        /// Calculates the area of the shape.
        /// </summary>
        /// <remarks>
        /// Algorithm courtesy of http://alienryderflex.com/polygon_area/
        /// </remarks>
        /// <returns>Area of the shape.</returns>
        protected override double CalculateArea()
        {
            double area = 0;

            int length = this.vertices.Length;

            for (
                int i = 0, j = length - 1;
                i < length;
                j = i, i++)
            {
                Point pointi = this.vertices[i];
                Point pointj = this.vertices[j];

                area += (pointj.X + pointi.X) * (pointj.Y - pointi.Y);
            }

            return Math.Abs(area * 0.5);
        }
    }
}
