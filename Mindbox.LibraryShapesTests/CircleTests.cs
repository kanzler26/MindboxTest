using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Mindbox.LibraryShapes.Tests {
    [TestClass()]
    public class CircleTests {
        [TestMethod()]
        public void GetAreaTestInCircle_PiNumIncRad5Pow_Expected78_5() {
            const double radius = 5;
            const double expected = 78.5;
            Circle circle = new Circle(radius);
            var result = circle.GetArea();
            Assert.AreEqual(expected, result);
        }
    }
}