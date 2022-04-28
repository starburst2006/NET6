using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrvniKonzolovaApp.Model;

namespace Tests
{
    [TestClass]
    public class Point2DQuadrant
    {
        [TestMethod]
        public void TestOrigin()
        {
            _2D point = new _2D(0, 0);

            var quadrant = point.GetQuadrant();

            Assert.AreEqual(Quadrant.Origin, quadrant);
        }

        [TestMethod]
        public void TestQuadrant1()
        {
            _2D point = new _2D(1, 1);

            var quadrant = point.GetQuadrant();

            Assert.AreEqual(Quadrant.Quadrant1, quadrant);
        }

        [TestMethod]
        public void TestQuadrant2()
        {
            _2D point = new _2D(-1, 1);

            var quadrant = point.GetQuadrant();

            Assert.AreEqual(Quadrant.Quadrant2, quadrant);
        }

        [TestMethod]
        public void TestQuadrant3()
        {
            _2D point = new _2D(-1, -1);

            var quadrant = point.GetQuadrant();

            Assert.AreEqual(Quadrant.Quadrant3, quadrant);
        }

        [TestMethod]
        public void TestQuadrant4()
        {
            _2D point = new _2D(1, -1);

            var quadrant = point.GetQuadrant();

            Assert.AreEqual(Quadrant.Quadrant4, quadrant);
        }
    }
}