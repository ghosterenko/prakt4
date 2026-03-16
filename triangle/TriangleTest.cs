using GeometryShape;
namespace triangle
{
    public class triangleTest
    {
        [Fact]
        public void CheckMethodAreaForTriangle()
        {
            Triangle triangle = new Triangle( );
            triangle.SideA = 13;
            triangle.SideB = 14;
            triangle.SideC = 15;
            var result = 84;
            Assert.Equal(result, triangle.Area());
        }
        [Fact]
        public void CheckMethodPerimeterForTriangle()
        {
            Triangle triangle = new Triangle( );
            triangle.SideA = 10;
            triangle.SideB = 10;
            triangle.SideC = 10;
            var result = 30;
            Assert.Equal(result, triangle.Perimeter());
        }
    }
}