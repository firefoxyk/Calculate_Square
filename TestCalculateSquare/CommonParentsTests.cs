using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSquare.Test
{
    public class CommonParentsTests
    {
        [Fact]
        public void TriangleAndCircleHaveCommonParent()
        {
            //Arrange
            var triangle = new Triangle(a: 6d, b: 8d, c: 10d);
            var circle = new Circle(radius: 5d);
            //Act/Assert
            triangle.Should().BeAssignableTo<IFigure>();
            circle.Should().BeAssignableTo<IFigure>();
        }
    }
}
