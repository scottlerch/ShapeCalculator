//-----------------------------------------------------------------------
// <copyright file="EllipseTest.cs" company="N/A">
//     Copyright Scott Lerch. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace ShapeLibrary.UnitTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ShapeLibrary;

    /// <summary>
    /// This is a test class for Ellipse.
    /// </summary>
    [TestClass]
    public class EllipseTest
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
            double radiusA = 0;
            double radiusB = 0;

            Ellipse target = new Ellipse(radiusA, radiusB);

            Assert.AreEqual(radiusA, target.RadiusA);
            Assert.AreEqual(radiusB, target.RadiusB);
        }

        /// <summary>
        /// A test for constructor exception.
        /// </summary>
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ConstructorExceptionTest()
        {
            Ellipse target = new Ellipse(-1, -1);
        }

        /// <summary>
        /// A test for Radius.
        /// </summary>
        [TestMethod]
        public void RadiusATest()
        {
            double radiusA = 0;
            double expected = 10;
            double actual;

            Ellipse target = new Ellipse(radiusA, 0);

            target.RadiusA = expected;
            actual = target.RadiusA;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for property set exception.
        /// </summary>
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void RadiusAExceptionTest()
        {
            Ellipse target = new Ellipse(0, 0);
            target.RadiusA = -1;
        }

        /// <summary>
        /// A test for calculating area.
        /// </summary>
        [TestMethod]
        public void AreaTest()
        {
            Ellipse target = new Ellipse(0, 0);

            Assert.AreEqual(0, target.Area);

            target.RadiusA = 5;
            target.RadiusB = 10;

            double expected = Math.PI * target.RadiusA * target.RadiusB;
            double actual = target.Area;
            double epsilon = 0.1;

            Assert.IsTrue(Math.Abs(actual - expected) < epsilon);
        }
    }
}
