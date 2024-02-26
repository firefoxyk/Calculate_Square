using FluentAssertions;

namespace CalculateSquare.Test.CircleTests
{
    public class CalculateCircleSquareTests
    {
        [Theory]
        [InlineData(5, 78.53981633974483)]
        [InlineData(10, 314.1592653589793)]
        [InlineData(2.5, 19.634954084936208)]
        public void ShouldCalculateCircleAreaCorrectly(double radius, double expectedArea)
        {
            //Arrange
            var circle = new Circle(radius);
            //Act
            var calculatedArea = circle.Square;
            //Assert
            Assert.Equal(expectedArea, calculatedArea, 10);
        }
    }
}
