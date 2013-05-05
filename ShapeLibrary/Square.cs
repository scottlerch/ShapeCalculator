//-----------------------------------------------------------------------
// <copyright file="Square.cs" company="N/A">
//     Copyright Scott Lerch. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ShapeLibrary
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Square shape class.
    /// </summary>
    /// <remarks>
    /// There are some trade-offs with Square inheriting from Rectangle.
    /// When Square inherits from Rectangle it unnecessarily keeps track of
    /// a separate Length and Width field, and because the shapes are mutable it 
    /// makes setting the Length and Width properties awkward since they must 
    /// always be equal.  However, by having Square inherit from Rectangle it 
    /// follows the intuitive "is-a" relationship and allows casting from Square
    /// to Rectangle, plus we can re-use almost all of Rectangle for the 
    /// implementation.
    /// </remarks>
    public class Square : Rectangle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class.
        /// </summary>
        public Square()
            : this(0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <exception cref="ArgumentException">
        /// Length cannot be less than zero.
        /// </exception>
        public Square(double length) : base(length, length)
        {
        }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <remarks>
        /// The Width property will automatically be updated to match Length.
        /// </remarks>
        /// <exception cref="ArgumentException">
        /// Length cannot be less than zero.
        /// </exception>
        public override double Length
        {
            get
            {
                return base.Length;
            }

            set
            {
                this.Update(value, value);
            }
        }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <remarks>
        /// The Length property will automatically be updated to match Width.
        /// </remarks>
        /// <exception cref="ArgumentException">
        /// Width cannot be less than zero.
        /// </exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public override double Width
        {
            get
            {
                return base.Width;
            }

            set
            {
                this.Update(value, value);
            }
        }

        /// <summary>
        /// Updates the size of the rectangle.
        /// </summary>
        /// <remarks>
        /// Length and Width must be equal.
        /// </remarks>
        /// <param name="length">The length.</param>
        /// <param name="width">The width.</param>
        /// <exception cref="ArgumentException">
        /// Length and width must equal and cannot be less than zero.
        /// </exception>
        public override void Update(double length, double width)
        {
            // Handle special case here where two doubles equal to NaN
            // can't be directly compared.
            if (length != width && !double.IsNaN(length) && !double.IsNaN(width))
            {
                throw new ArgumentException("Length must be equal to width");
            }

            base.Update(length, width);
        }
    }
}
