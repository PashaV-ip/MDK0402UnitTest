using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleCreater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCreater.Tests
{
    [TestClass()]
    public class TriangleCalculatorTests
    {
        [TestMethod()]
        public void CheckTriangleTypeTest_Negativ_Test()
        {
            TriangleCalculator triangle = new TriangleCalculator();
            Assert.AreEqual(TriangleType.Impossible, triangle.CheckTriangleType(2, 5, 2));
        }
        [TestMethod()]
        public void CheckTriangleTypeTest_For_An_Equilateral_Triangle()
        {
            TriangleCalculator triangle = new TriangleCalculator();
            Assert.AreEqual(TriangleType.Equilateral, triangle.CheckTriangleType(3, 3, 3));
        }
        [TestMethod()]
        public void CheckTriangleTypeTest_For_An_Isosceles_Triangle()
        {
            TriangleCalculator triangle = new TriangleCalculator();
            Assert.AreEqual(TriangleType.Isosceles, triangle.CheckTriangleType(3, 2, 3));
        }
        [TestMethod()]
        public void CheckTriangleTypeTest_For_An_Versatile_Triangle()
        {
            TriangleCalculator triangle = new TriangleCalculator();
            Assert.AreEqual(TriangleType.Versatile, triangle.CheckTriangleType(3, 2, 4));
        }
    }
}