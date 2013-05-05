//-----------------------------------------------------------------------
// <copyright file="SquareTest.cs" company="N/A">
//     Copyright Scott Lerch. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ShapeLibrary.UnitTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ShapeLibrary;

    /// <summary>
    /// This is a test class for Square.
    /// </summary>
    [TestClass]
    public class SquareTest
    {
        /// <summary>
        /// The test context instance.
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
        /// A test for Square Constructor.
        /// </summary>
        [TestMethod]
        public void ConstructorTest()
        {
            double length = 0;

            Square target = new Square(length);

            Assert.AreEqual(length, target.Length);
        }

        /// <summary>
        /// A test for constructor exception.
        /// </summary>
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ConstructorExceptionTest()
        {
            Square target = new Square(-1);
        }

        /// <summary>
        /// A test for Width.
        /// </summary>
        [TestMethod]
        public void WidthTest()
        {
            double length = 0;
            double expected = 10;
            double actual;

            Square target = new Square(length);

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
            double length = 0;
            double expected = 10;
            double actual;

            Square target = new Square(length);
   
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
        /// A test for calculating area.
        /// </summary>
        [TestMethod]
        public void LengthEqualsWidthTest()
        {
            Square target = new Square(0);

            target.Width = 10;
            Assert.AreEqual(target.Length, target.Width);

            target.Length = 20;
            Assert.AreEqual(target.Length, target.Width);
        }

        /// <summary>
        /// A test for calculating area.
        /// </summary>
        [TestMethod]
        public void AreaTest()
        {
            Square target = new Square(0);

            target.Length = double.Epsilon;
            Assert.AreEqual(double.Epsilon * double.Epsilon, target.Area);

            target.Length = 0;
            Assert.AreEqual(0, target.Area);

            target.Length = 1;
            Assert.AreEqual(1, target.Area);

            target.Length = 2;
            Assert.AreEqual(4, target.Area);

            target.Length = double.MaxValue;
            Assert.AreEqual(double.PositiveInfinity, target.Area);

            target.Length = double.NaN;
            Assert.IsTrue(double.IsNaN(target.Area));
        }

        /// <summary>
        /// A test for casting to Rectangle.
        /// </summary>
        [TestMethod]
        public void CastToRectangleTest()
        {
            Square target = new Square(10);

            Rectangle rectangle = target;
            rectangle.Length = 2;
            rectangle.Width = 3;

            double expected = 9;

            Assert.AreEqual(expected, rectangle.Area);
        }

        /// <summary>
        /// A test for casting to Rectangle.
        /// </summary>
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void CastToRectangleExceptionTest()
        {
            Square target = new Square(10);

            Rectangle rectangle = target;
            rectangle.Update(2, 3);
        }
    }
}
