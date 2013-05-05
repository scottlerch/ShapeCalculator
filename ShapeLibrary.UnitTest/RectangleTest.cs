//-----------------------------------------------------------------------
// <copyright file="RectangleTest.cs" company="N/A">
//     Copyright Scott Lerch. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ShapeLibrary.UnitTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ShapeLibrary;
    
    /// <summary>
    /// This is a test class for Rectangle.
    /// </summary>
    [TestClass]
    public class RectangleTest
    {
        /// <summary>
        /// The text context instance.
        /// </summary>
        private TestContext testContextInstance;

        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext
        {
            get
            {
                return this.testContextInstance;
            }

            set
            {
                this.testContextInstance = value;
            }
        }

        /// <summary>
        /// A test for Rectangle Constructor
        /// </summary>
        [TestMethod]
        public void ConstructorTest()
        {
            double length = 0;
            double width = 0;

            Rectangle target = new Rectangle(length, width);

            Assert.AreEqual(length, target.Length);
            Assert.AreEqual(width, target.Width);
        }

        /// <summary>
        /// A test for constructor exception.
        /// </summary>
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ConstructorLengthTestException()
        {
            Rectangle target = new Rectangle(-1, 0);
        }

        /// <summary>
        /// A test for constructor exception.
        /// </summary>
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ConstructorWidthTestException()
        {
            Rectangle target = new Rectangle(0, -1);
        }

        /// <summary>
        /// A test for Width.
        /// </summary>
        [TestMethod]
        public void WidthTest()
        {
            double expected = 10;
            double actual;

            Rectangle target = new Rectangle(0, 0);

            target.Width = expected;
            actual = target.Width;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for property set exception.
        /// </summary>
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void WidthExceptionTest()
        {
            Square target = new Square(0);
            target.Width = -1;
        }

        /// <summary>
        /// A test for Length.
        /// </summary>
        [TestMethod]
        public void LengthTest()
        {
            double expected = 10;
            double actual;

            Rectangle target = new Rectangle(0, 0);

            target.Length = expected;
            actual = target.Length;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for property set exception.
        /// </summary>
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void LengthExceptionTest()
        {
            Square target = new Square(0);
            target.Length = -1;
        }

        /// <summary>
        /// A test for Update
        /// </summary>
        [TestMethod]
        public void UpdateTest()
        {
            double length = 10;
            double width = 10;

            Rectangle target = new Rectangle(0, 0);

            target.Update(length, width);

            Assert.AreEqual(length, target.Length);
            Assert.AreEqual(width, target.Width);
        }

        /// <summary>
        /// A test for calculating area.
        /// </summary>
        [TestMethod]
        public void AreaTest()
        {
            Rectangle target = new Rectangle(0, 0);

            target.Length = double.Epsilon;
            target.Width = double.Epsilon;
            Assert.AreEqual(double.Epsilon * double.Epsilon, target.Area);

            target.Length = 0;
            target.Width = 0;
            Assert.AreEqual(0, target.Area);

            target.Length = 1;
            target.Width = 0;
            Assert.AreEqual(0, target.Area);

            target.Length = 0;
            target.Width = 1;
            Assert.AreEqual(0, target.Area);

            target.Length = 1;
            target.Width = 1;
            Assert.AreEqual(1, target.Area);

            target.Length = 2;
            target.Width = 3;
            Assert.AreEqual(6, target.Area);

            target.Length = double.MaxValue;
            target.Width = 2;
            Assert.AreEqual(double.PositiveInfinity, target.Area);

            target.Length = double.MaxValue;
            target.Width = 1;
            Assert.AreEqual(double.MaxValue, target.Area);

            target.Length = double.NaN;
            target.Width = 1;
            Assert.AreEqual(double.NaN, target.Area);

            target.Length = 1;
            target.Width = double.NaN;
            Assert.IsTrue(double.IsNaN(target.Area));
        }
    }
}
