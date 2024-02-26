using FluentAssertions;

namespace CalculateSquare.Test.TriangleTests
{
    public class CalculateTriangleSquareTests
    {
        [Theory]
        [InlineData(14, 13, 15, 84)]
        [InlineData(3, 4, 5, 6)]
        [InlineData(2, 2, 3, 1.984313483298443)]
        public void CalculateTriangleArea(double a, double b, double c, double result)
        {
            //Arrange
            var triangle = new Triangle(a, b, c);
            //Act
            var area = triangle.Square;
            //Assert
            Assert.Equal(result, area, 10);
        }
    }
}