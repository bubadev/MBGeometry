using MBGeometry.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBGeometry.Figures.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void GetSquareTest()
        {
            var circle = new CircleModel() { Radius = 10 };
            Assert.AreEqual(314.15926535897933, new Circle(circle).GetSquare());
        }

        [TestMethod()]
        public void NegativeRadiusTest()
        {
            var circle = new CircleModel() { Radius = -10 };
            Assert.ThrowsException<ArgumentException>(() => new Circle(circle));
        }

        [TestMethod()]
        public void MaxValueRadiusTest()
        {
            var circle = new CircleModel() { Radius = Double.MaxValue * 2 };
            Assert.ThrowsException<ArgumentException>(() => new Circle(circle));
        }
    }
}