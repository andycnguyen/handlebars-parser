using Xunit;

namespace MyFirstUnitTests
{
    public class Tests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(3, Add(1, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}