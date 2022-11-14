using Microsoft.VisualStudio.TestTools.UnitTesting;
using MBGeometry.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBGeometry.Models;

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