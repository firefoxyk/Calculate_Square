using FluentAssertions;

namespace CalculateSquare.Test.CircleTests
{
    public class CreatingCircleTests
    {
        [Fact]
        public void CircleHasCorrectRadius()
        {
            //Arrange/Act
            var circle = new Circle(radius: 4);
            //Assert
            circle.Radius.Should().Be(4d);
        }

        [Theory]
        [InlineData(-3d)]
        [InlineData(0d)]
        [InlineData(double.NaN)]
        [InlineData(double.PositiveInfinity)]
        public void CircleCreationWithNegativeRadiusThrowsException(double radius)
        {
            //Arrange/Act/Assert
            FluentActions.Invoking(() => new Circle(radius))
                .Should()
                .ThrowExactly<ArgumentOutOfRangeException>();
        }
    }
}
