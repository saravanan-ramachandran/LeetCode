using LeetCode.Arrays;

namespace LeetCode.Tests.Arrays
{
    public class LongestConsecutiveTests
    {
        [Theory]
        [InlineData(new int[] { 100, 4, 200, 1, 3, 2 }, 4)]
        public void LongestConsecutiveV3(int[] input, int expected)
        {
            Solution solution = new();
            var actual = solution.LongestConsecutiveV3(input);
            Assert.Equal(expected, actual);
        }
    }
}