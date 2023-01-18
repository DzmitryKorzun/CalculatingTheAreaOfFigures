namespace Tests
{
    public class TriangleTests
    {

        [Fact]
        public void TheCorrectTriangleCreation()
        {
            var triangleObj = Triangle.Create(3,4,5);
            Assert.NotNull(triangleObj);
        }
        [Fact]
        public void CreationTriangleUsingNegativeSide()
        {
            bool isUncorrectSideA = false;
            bool isUncorrectSideB = false;
            bool isUncorrectSideC = false;
            try
            {
                Triangle.Create(-3, 4, 5);
            }
            catch
            {
                isUncorrectSideA = true;
            }
            try
            {
                Triangle.Create(3, -4, 5);
            }
            catch
            {
                isUncorrectSideB = true;
            }
            try
            {
                Triangle.Create(3, 4, -5);
            }
            catch
            {
                isUncorrectSideC = true;
            }
            Assert.True(isUncorrectSideA);
            Assert.True(isUncorrectSideB);
            Assert.True(isUncorrectSideC);
        }
       
        [Fact]
        public void CalculationsOfTheAreaOfRightTriangle()
        {
            float expectedArea = 24f;
            var triangleObj = Triangle.Create(6, 8, 10);
            Assert.Equal(expectedArea, triangleObj.GetArea());
        }
        [Fact]
        public void CalculationsTriangleAreaByOnThreeSides()
        {
            float expectedArea = 26.832815f;
            var triangleObj = Triangle.Create(7, 8, 9);
            Assert.Equal(expectedArea, triangleObj.GetArea());            
        }
        [Fact]
        public void CreateEquilateralTriangle()
        {
            float expectedArea = 10.825317f;
            var triangleObj = Triangle.Create(5, 5, 5);
            Assert.Equal(expectedArea, triangleObj.GetArea());
        }        
    }
}