//-----------------------------------------------------------------------
// <copyright file="Circle.cs" company="N/A">
//     Copyright Scott Lerch. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ShapeLibrary
{
    using System;

    /// <summary>
    /// Circle shape class.
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// The radius of the circle.
        /// </summary>
        private double radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        public Circle()
            : this(0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">The radius.</param>
        /// <exception cref="ArgumentException">
        /// Radius cannot be less than zero.
        /// </exception>
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Gets or sets the radius.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Radius cannot be less than zero.
        /// </exception>
        public double Radius 
        {
            get 
            { 
                return this.radius; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius cannot be less than zero");
                }

                if (this.radius != value)
                {
                    this.radius = value;
                    this.UpdateArea();
                    this.OnPropertyChanged("Radius");
                }
            }
        }

        /// <summary>
        /// Calculates the area of the shape.
        /// </summary>
        /// <returns>Area of the shape.</returns>
        protected override double CalculateArea()
        {
            return Math.PI * this.radius * this.radius;
        }
    }
}
