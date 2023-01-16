namespace Tests
{
    public class Triangles
    {
        [Fact]
        public void The—orrectTriangle—reation()
        {
            var triangleObj = Triangle.Create(3,4,5);
            Assert.NotNull(triangleObj);
        }
        [Fact]
        public void TheUncorrectTriangle—reation()
        {
            Triangle triangleObj;
            bool errorChecker = false;
            try
            {
                triangleObj = Triangle.Create(-3, 4, 5);
            }
            catch
            {
                errorChecker = true;
            }
            Assert.True(errorChecker);
        }
        [Fact]
        public void CalculationsOfTheAreaOfRightTriangle()
        {
            Triangle triangleObj;
            bool errorChecker = false;
            try
            {
                triangleObj = Triangle.Create(6, 8, 10);
                Assert.Equal(24f, triangleObj.Square());
            }
            catch
            {
                errorChecker = true;
            }
            Assert.False(errorChecker);
        }
        [Fact]
        public void CalculationsTriangleAreaByOnThreeSides()
        {
            Triangle triangleObj;
            bool errorChecker = false;
            try
            {
                triangleObj = Triangle.Create(7, 8, 9);
                Assert.Equal(26.832815f, triangleObj.Square());
            }
            catch
            {
                errorChecker = true;
            }
            Assert.False(errorChecker);
        }


    }
}