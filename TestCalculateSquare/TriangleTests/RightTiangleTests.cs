using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSquare.Test.TriangleTests
{
    public class RightTiangleTests
    {
        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(5, 12, 13, true)]
        [InlineData(1, 1, 1, false)]
        public void TriangleCheckIfIsRight(double a, double b, double c, bool expected)
        {
            //Arrange
            var triangle = new Triangle(a, b, c);
            //Act
            bool isRightTriangle = triangle.IsItRightTriangle();
            //Assert
            Assert.Equal(expected, isRightTriangle);
        }
    }
}
