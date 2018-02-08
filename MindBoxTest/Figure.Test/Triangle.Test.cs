using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace Figure.Test
{
    [TestClass]
    public class TriangleTest
    {
        /// <summary>
        /// Проверка на положительность результата вычисления площади
        /// </summary>
        [TestMethod]
        [Fact(DisplayName = "TriangleSquareCorrectTest")]
        public void TriangleSquareCorrectTest()
        {
            IFigure triangle = new Triangle(2, 2, 3);
            var result = triangle.Square();
            Assert.IsTrue(result > 0, "Square is < 0 or is null");
        }

        /// <summary>
        /// Проверка на возвращение null значения метода Square()
        /// </summary>
        [TestMethod]
        [Fact(DisplayName = "TriangleSquareReturnsNullTest")]
        public void TriangleSquareReturnsNullTest()
        {
            IFigure triangle = new Triangle(1, 1, 4);
            var result = triangle.Square();
            Assert.IsTrue(result == null, "Triangle does not exist.");
        }
    }
}
