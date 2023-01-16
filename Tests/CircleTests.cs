namespace Tests
{
    public class CircleTests
    {
        [Fact]
        public void CreateCorrectCircle()
        {
            Circle circleObj;
            bool errorChecker = false;
            try
            {
                circleObj = Circle.Create(7);
                Assert.NotNull(circleObj);
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
            Circle circleObj;
            bool errorChecker = false;
            try
            {
                circleObj = Circle.Create(-7);
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
            Circle circleObj;
            bool errorChecker = false;
            try
            {
                circleObj = Circle.Create(4);
                Assert.Equal(50.265484f, circleObj.Square());
            }
            catch
            {
                errorChecker = true;
            }
            Assert.False(errorChecker);
        }
    }
}
