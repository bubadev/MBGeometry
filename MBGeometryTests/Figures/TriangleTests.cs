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
    public class TriangleTests
    {
        [TestMethod()]
        public void GetSquareTest()
        {
            var triangle = new TriangleModel() { Sides = new double[] {3,4,5}};
            Assert.AreEqual(6, new Triangle(triangle).GetSquare());
        }
        [TestMethod()]
        public void NegativeSideTest()
        {
            var triangle = new TriangleModel() { Sides = new double[] { -3, 4, 5 } };
            Assert.ThrowsException<ArgumentException>(() => new Triangle(triangle));
        }
        [TestMethod()]
        public void InvalidSidesCountTest()
        {
            var triangle = new TriangleModel() { Sides = new double[] { 2, 3, 4, 5 } };
            Assert.ThrowsException<ArgumentException>(() => new Triangle(triangle));
        }
        [TestMethod()]
        public void NullSidesTest()
        {
            var triangle = new TriangleModel() {  };
            Assert.ThrowsException<ArgumentException>(() => new Triangle(triangle));
        }
        [TestMethod()]
        public void InvalidSideLenghtTest()
        {
            var triangle = new TriangleModel() { Sides = new double[] { 30, 4, 5 } };
            Assert.ThrowsException<ArgumentException>(() => new Triangle(triangle));
        }
        [TestMethod()]
        public void MaxValueSideTest()
        {
            var triangle = new TriangleModel() { Sides = new double[] { 3, 4, Double.MaxValue * 2 } };
            Assert.ThrowsException<ArgumentException>(() => new Triangle(triangle));
        }
        [TestMethod()]
        public void IsRightTest()
        {
            var triangle = new TriangleModel() { Sides = new double[] { 7, 24, 25 } };
            Assert.AreEqual(true, new Triangle(triangle).IsRight());
        }
    }
}