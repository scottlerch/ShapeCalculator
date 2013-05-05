//-----------------------------------------------------------------------
// <copyright file="Shape.cs" company="N/A">
//     Copyright Scott Lerch. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ShapeLibrary
{
    using System.ComponentModel;

    /// <summary>
    /// Shape base class.
    /// </summary>
    public abstract class Shape : INotifyPropertyChanged
    {
        /// <summary>
        /// The current area of the shape.
        /// </summary>
        private double area;

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the area.
        /// </summary>
        public double Area
        {
            get 
            { 
                return this.area;
            }

            private set
            {
                if (this.area != value)
                {
                    this.area = value;
                    this.OnPropertyChanged("Area");
                }
            }
        }

        /// <summary>
        /// Calculates the area of the shape.
        /// </summary>
        /// <returns>Area of the shape.</returns>
        protected abstract double CalculateArea();

        /// <summary>
        /// Updates the area.
        /// </summary>
        protected void UpdateArea()
        {
            this.Area = this.CalculateArea();
        }

        /// <summary>
        /// Called when the specified property changed.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(
                    this, 
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
