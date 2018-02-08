using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace Figure.Test
{
    [TestClass]
    public class CircleTest
    {
        /// <summary>
        /// Проверка на положительность результата вычисления площади
        /// </summary>
        [TestMethod]
        [Fact(DisplayName = "CircleSquareCorrectTest")]
        public void CircleSquareCorrectTest()
        {
            IFigure circle = new Circle(5);
            var result = circle.Square();
            Assert.IsTrue(result > 0, "Square is < 0 or is null");
        }

        /// <summary>
        /// Проверка на возвращение null значения метода Square()
        /// </summary>
        [TestMethod]
        [Fact(DisplayName = "CircleSquareReturnsNullTest")]
        public void CircleSquareReturnsNullTest()
        {
            IFigure circle = new Circle(-5);
            var result = circle.Square();
            Assert.IsTrue(result == null, "Radius is < 0. Circle does not exist.");
        }
    }
}
