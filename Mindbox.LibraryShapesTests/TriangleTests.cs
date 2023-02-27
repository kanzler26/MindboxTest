using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox.LibraryShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.LibraryShapes.Tests {
    [TestClass()]
    public class TriangleTests {
        [TestMethod()]
        public void GetAreaTestInTriangle_A6_B8_C10_Expected24() {
            double a = 6;
            double b = 8;
            double c = 10;
            double expected = 24;
            Triangle triangle = new(a, b, c);
            double result = triangle.GetArea();
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void isRectangularTest_A6IncA6PlusB8IncB8EqualC10IncC10_ExpTrue() {
            double a = 6;
            double b = 8;
            double c = 10;
            bool exp = true;
            Triangle triangle = new(a, b, c);
            var result = triangle.isRectangular();
            Assert.AreEqual(result, exp);
        }
    }
}