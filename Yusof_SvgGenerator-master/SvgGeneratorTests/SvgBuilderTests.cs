using Microsoft.VisualStudio.TestTools.UnitTesting;
using SvgGenerator;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;

namespace SvgGeneratorTests
{
    [TestClass]
    public class SvgBuilderTests
    {
        [TestMethod]
        public void CreatingOneSquareGeneratesOneRect()
        {
            var shape1 = new Square(Color.Blue, 0, 0, 225);

            var shapeList = new List<Shape>() { shape1 };
            var svgBuilder = new SvgBuilder();
            var content = svgBuilder.Build(shapeList);
            Assert.IsTrue(content.Contains("rect"));
            Assert.AreEqual(1, Regex.Matches(content, "rect").Count);
        }

        [TestMethod]
        public void CreatingThreeSquareGeneratesOneRect()
        {
            var shape1 = new Square(Color.Blue, 0, 0, 225);
            var shape2 = new Square(Color.Red, 1, 0, 225);
            var shape3 = new Square(Color.Green, 2, 0, 225);

            var shapeList = new List<Shape>() { shape1, shape2, shape3 };
            var svgBuilder = new SvgBuilder();
            var content = svgBuilder.Build(shapeList);
            Assert.IsTrue(content.Contains("rect"));
            Assert.AreEqual(3, Regex.Matches(content, "rect").Count);
        }
    }
}
