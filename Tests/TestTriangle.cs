using areaOfFigures;
using System;

namespace Tests
{
    [TestClass]
    public class TestTriangle
    {
        [TestMethod]
        public void TriangleTestRightNumber()
        {
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => new Triangle(-3, 1, 1));
        }

        [TestMethod]
        public void TriangleTestExist()
        {
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => new Triangle(1, 2, 3));
        }

        [TestMethod]
        public void TriangleTestCalculateArea()
        {
            Triangle triangle = new Triangle(4, 5, 6);
            Assert.AreEqual(9.921567416492215, triangle.Area());
        }

    }
}