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
<<<<<<< HEAD
            triangle.SideA = 20;
=======
            triangle.SideA = 10;
>>>>>>> 4d421d1581326a6efc6d7fc3824f4f351ddea08e
            triangle.SideB = 10;
            triangle.SideC = 10;
            var result = 40;
            Assert.Equal(result, triangle.Perimeter());
        }
    }
}