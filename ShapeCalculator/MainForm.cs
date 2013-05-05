//-----------------------------------------------------------------------
// <copyright file="MainForm.cs" company="N/A">
//     Copyright Scott Lerch. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ShapeCalculator
{
    using System;
    using System.Windows.Forms;
    using ShapeLibrary;

    /// <summary>
    /// Main form for shape calculator.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Called when form loads.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        /// The <see cref="System.EventArgs"/> instance containing the event 
        /// data.
        /// </param>
        private void OnFormLoad(object sender, EventArgs e)
        {
            this.bindingSourceCircle.DataSource = new Circle();
            this.bindingSourceSquare.DataSource = new Square();
            this.bindingSourceRectangle.DataSource = new Rectangle();
            this.bindingSourceEllipse.DataSource = new Ellipse();
        }
    }
}
