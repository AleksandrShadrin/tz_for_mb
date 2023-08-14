using FluentAssertions;

namespace Figures.Tests
{
    public class FiguresTests
    {
        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(5, 12, 13)]
        [InlineData(7, 24, 25)]
        [InlineData(8, 15, 17)]
        [InlineData(20, 21, 29)]
        [InlineData(12, 35, 37)]
        [InlineData(9, 40, 41)]
        public void Rectangular_Triangles_Should_Return_True_When_Check_On_It(double a, double b, double c)
        {
            // ARRANGE
            var triangle = new Triangle(a, b, c);

            // ACT
            var result = triangle.TriangleIsRectangular();

            // ASSERT
            result.Should()
                .BeTrue();
        }

        [Theory]
        [InlineData(3, 28.274)]
        [InlineData(4.5, 63.617)]
        public void Circle_Area_Should_Be_Correctly_Evaluated(double radius, double shouldBe)
        {
            // ARRANGE
            var circle = new Circle(radius);

            // ACT
            var area = circle.GetArea();

            // ASSERT
            area.Should()
                .BeApproximately(shouldBe, 3);
        }

        [Theory]
        [InlineData(0, 1, 2)]
        [InlineData(1, 0, 2)]
        [InlineData(1, 2, 0)]
        [InlineData(-1, -2, -3)]
        [InlineData(-2, -3, -4)]
        public void Triangle_That_Not_Exist_Should_Throw_NotRealTriangleException
        (
            double sideA, 
            double sideB, 
            double sideC
        )
        {
            // ARRANGE
            // ACT
            var act = () => new Triangle(sideA, sideB, sideC);
            
            // ASSERT
            act.Should()
                .Throw<NotRealTriangleException>();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Circle_With_Non_Positive_Radius_Should_Throw_NotPositiveArgumentsException
        (
            double radius
        )
        {
            // ARRANGE
            // ACT
            var act = () => new Circle(radius);

            // ASSERT
            act.Should()
                .Throw<NotPositiveArgumentsException>();
        }
    }
}
