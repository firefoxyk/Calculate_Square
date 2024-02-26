using FluentAssertions;

namespace CalculateSquare.Test.TriangleTests
{
    public class CreatingTriangleTests
    {
        [Fact]
        public void Triangle_has_correct_props()
        {
            //Arrange/Act
            var triangle = new Triangle(a: 2, b: 2, c: 3);
            //Assert
            triangle.SideA.Should().Be(2d);
            triangle.SideB.Should().Be(2d);
            triangle.SideC.Should().Be(3d);
        }

        [Theory]
        [InlineData(-2d, 2d, 3d)]
        [InlineData(2d, -2d, 3d)]
        [InlineData(2d, 2d, -3d)]
        [InlineData(0d, 2d, 3d)]
        [InlineData(2d, 0d, 3d)]
        [InlineData(2d, 2d, 0d)]
        [InlineData(double.NaN, 2d, 3d)]
        [InlineData(2d, double.NaN, 3d)]
        [InlineData(2d, 2d, double.NaN)]
        [InlineData(double.PositiveInfinity, 2d, 3d)]
        [InlineData(2d, double.PositiveInfinity, 3d)]
        [InlineData(2d, 2d, double.PositiveInfinity)]
        [InlineData(double.NegativeInfinity, 2d, 3d)]
        [InlineData(2d, double.NegativeInfinity, 3d)]
        [InlineData(2d, 2d, double.NegativeInfinity)]
        public void TriangleCreationWithNegativeSidesThrowsException(double a, double b, double c)
        {
            //Arrange/Act/Assert
            FluentActions.Invoking(() => new Triangle(a, b, c))
                .Should()
                .ThrowExactly<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1d, 2d, 4d)]
        [InlineData(4d, 2d, 1d)]
        [InlineData(1d, 3d, 1d)]
        public void TriangleCreationWithIncorrectSidesThrowsArgumentException(double a, double b, double c)
        {
            //Arrange/Act/Assert
            FluentActions.Invoking(() => new Triangle(a, b, c))
                .Should()
                .Throw<ArgumentException>();

        }
    }
}
