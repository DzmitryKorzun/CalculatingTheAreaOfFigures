namespace Tests
{
    public class CircleTests
    {
        [Fact]
        public void CreateCorrectCircle()
        {
            bool errorChecker = false;
            try
            {
                Circle.Create(7);
            }
            catch
            {
                errorChecker = true;
            }
            Assert.False(errorChecker);
        }
        [Fact]
        public void CreateUncorrectCircle()
        {
            bool errorChecker = false;
            try
            {
                Circle.Create(-7);
            }
            catch
            {
                errorChecker = true;
            }
            Assert.True(errorChecker);
        }
        [Fact]
        public void AreaOfCircle()
        {
            float expectedArea = 50.265484f;
            var circleObj = Circle.Create(4);
            Assert.Equal(expectedArea, circleObj.GetArea());
        }
    }
}