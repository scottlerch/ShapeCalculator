//-----------------------------------------------------------------------
// <copyright file="CircleTest.cs" company="N/A">
//     Copyright Scott Lerch. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ShapeLibrary.UnitTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ShapeLibrary;
    
    /// <summary>
    /// This is a test class for Circle.
    /// </summary>
    [TestClass]
    public class CircleTest
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
        /// A test for Circle Constructor.
        /// </summary>
        [TestMethod]
        public void ConstructorTest()
        {
            double radius = 0;

            Circle target = new Circle(radius);

            Assert.AreEqual(radius, target.Radius);
        }

        /// <summary>
        /// A test for constructor exception.
        /// </summary>
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ConstructorExceptionTest()
        {
            Circle target = new Circle(-1);
        }

        /// <summary>
        /// A test for Radius.
        /// </summary>
        [TestMethod]
        public void RadiusTest()
        {
            double radius = 0;
            double expected = 10;
            double actual;

            Circle target = new Circle(radius);

            target.Radius = expected;
            actual = target.Radius;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for property set exception.
        /// </summary>
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void RadiusExceptionTest()
        {
            Circle target = new Circle(0);
            target.Radius = -1;
        }

        /// <summary>
        /// A test for calculating area.
        /// </summary>
        [TestMethod]
        public void AreaTest()
        {
            Circle target = new Circle(0);

            target.Radius = double.Epsilon;
            Assert.AreEqual(Math.PI * double.Epsilon * double.Epsilon, target.Area);

            target.Radius = 0;
            Assert.AreEqual(0, target.Area);

            target.Radius = 1;
            Assert.AreEqual(Math.PI, target.Area);

            target.Radius = 2;
            Assert.AreEqual(4 * Math.PI, target.Area);

            target.Radius = double.MaxValue;
            Assert.AreEqual(double.PositiveInfinity, target.Area);

            target.Radius = double.NaN;
            Assert.IsTrue(double.IsNaN(target.Area));
        }
    }
}
