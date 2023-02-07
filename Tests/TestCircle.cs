using areaOfFigures;
using System;

namespace Tests
{
    [TestClass]
    public class TestCircle
    {
        [TestMethod]
        public void CircleTestExist()
        {
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => new Circle(-3));
        }

        [TestMethod]
        public void CircleTestCalculateArea()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(78.53981633974483, circle.Area());
        }
    }
}