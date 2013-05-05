//-----------------------------------------------------------------------
// <copyright file="Rectangle.cs" company="N/A">
//     Copyright Scott Lerch. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ShapeLibrary
{
    using System;

    /// <summary>
    /// Rectangle shape class.
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// The length of the rectangle.
        /// </summary>
        private double length;

        /// <summary>
        /// The width of the rectangle.
        /// </summary>
        private double width;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        public Rectangle()
            : this(0, 0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <param name="width">The width.</param>
        /// <exception cref="ArgumentException">
        /// Length and width cannot be less than zero.
        /// </exception>
        public Rectangle(double length, double width)
        {
            this.Update(length, width);
        }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Length cannot be less than zero.
        /// </exception>
        public virtual double Length
        {
            get
            {
                return this.length;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Length cannot be less than zero");
                }

                if (this.length != value)
                {
                    this.length = value;
                    this.UpdateArea();
                    this.OnPropertyChanged("Length");
                }
            }
        }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Width cannot be less than zero.
        /// </exception>
        public virtual double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be less than zero");
                }

                if (this.width != value)
                {
                    this.width = value;
                    this.UpdateArea();
                    this.OnPropertyChanged("Width");
                }
            }
        }

        /// <summary>
        /// Updates the size of the rectangle.
        /// </summary>
        /// <remarks>
        /// This is useful for efficiently updating the rectangle if both
        /// the length and width are changing, otherwise setting the properties
        /// individually will cause the area to be calculated twice.
        /// </remarks>
        /// <param name="length">The length.</param>
        /// <param name="width">The width.</param>
        /// <exception cref="ArgumentException">
        /// Length and width cannot be less than zero.
        /// </exception>
        public virtual void Update(double length, double width)
        {
            if (length < 0)
            {
                throw new ArgumentException("Length cannot be less than zero");
            }

            if (width < 0)
            {
                throw new ArgumentException("Width cannot be less than zero");
            }

            this.length = length;
            this.width = width;

            this.UpdateArea();

            this.OnPropertyChanged("Length");
            this.OnPropertyChanged("Width");
        }

        /// <summary>
        /// Calculates the area of the shape.
        /// </summary>
        /// <returns>Area of the shape.</returns>
        protected override double CalculateArea()
        {
            return this.length * this.width;
        }
    }
}
