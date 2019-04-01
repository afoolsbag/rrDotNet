using Xunit;

namespace rrCS
{
    /// <summary>
    /// xUnit https://xunit.net/
    /// </summary>
    public class XUnit
    {
        [Fact]
        public void Fact()
        {
            Assert.Equal(4, 2 + 2);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        public void Theory(int value)
        {
            Assert.True(value % 2 == 1);
        }
    }
}
