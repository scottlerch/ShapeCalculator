//-----------------------------------------------------------------------
// <copyright file="Ellipse.cs" company="N/A">
//     Copyright Scott Lerch. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ShapeLibrary
{
    using System;

    /// <summary>
    /// Ellipse shape class.
    /// </summary>
    /// <remarks>
    /// This is implemented using the Polygon base class for demonstration
    /// purposes only.  An ellipses area can be easily calculated using the
    /// formula: Area = Pi * Radius A * Radius B.
    /// </remarks>
    public class Ellipse : Polygon
    {
        /// <summary>
        /// The resolution of the ellipse polygon.
        /// </summary>
        private const int Resolution = 1000;

        /// <summary>
        /// The radius A.
        /// </summary>
        private double radiusA;

        /// <summary>
        /// The radius B.
        /// </summary>
        private double radiusB;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipse"/> class.
        /// </summary>
        public Ellipse()
            : this(0, 0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipse"/> class.
        /// </summary>
        /// <param name="radiusA">The radius A.</param>
        /// <param name="radiusB">The radius B.</param>
        public Ellipse(double radiusA, double radiusB)
        {
            this.Update(radiusA, radiusB);
        }

        /// <summary>
        /// Gets or sets the radius A.
        /// </summary>
        public double RadiusA
        {
            get
            {
                return this.radiusA;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "Radius A cannot be less than zero");
                }

                if (this.radiusA != value)
                {
                    this.radiusA = value;
                    this.UpdateVertices();
                    this.OnPropertyChanged("RadiusA");
                }
            }
        }

        /// <summary>
        /// Gets or sets the radius B.
        /// </summary>
        public double RadiusB
        {
            get
            {
                return this.radiusB;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius B cannot be less than zero");
                }

                if (this.radiusB != value)
                {
                    this.radiusB = value;
                    this.UpdateVertices();
                    this.OnPropertyChanged("RadiusB");
                }
            }
        }

        /// <summary>
        /// Updates the ellipses using the specified radii.
        /// </summary>
        /// <param name="radiusA">The radius A.</param>
        /// <param name="radiusB">The radius B.</param>
        /// <exception cref="ArgumentException">
        /// Radii cannot be less than zero.
        /// </exception>
        public void Update(double radiusA, double radiusB)
        {
            if (radiusA < 0)
            {
                throw new ArgumentException("Radius A cannot be less than zero");
            }

            if (radiusB < 0)
            {
                throw new ArgumentException("Radius B cannot be less than zero");
            }

            this.radiusA = radiusA;
            this.radiusB = radiusB;

            this.UpdateVertices();

            this.OnPropertyChanged("RadiusA");
            this.OnPropertyChanged("RadiusB");
        }

        /// <summary>
        /// Updates the vertices.
        /// </summary>
        private void UpdateVertices()
        {
            Point[] vertices = new Point[Resolution];

            const double Tau = 2 * Math.PI;
            double stepSize = Tau / (double)Resolution;

            int i = 0;

            // Generate points along perimeter of ellipse clock-wise
            for (double t = Tau; t >= 0 && i < vertices.Length; t -= stepSize)
            {
                vertices[i++] = new Point(
                    this.radiusA * Math.Cos(t), 
                    this.radiusB * Math.Sin(t));
            }

            this.SetVertices(vertices);
        }
    }
}
