using LeetCode.Stack;

namespace LeetCode.Tests.Stack
{
    public class ValidParenthesesTests
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("[}", false)]
        public void IsValidV1(string input, bool expected)
        {
            Solution solution = new();
            var actual = solution.IsValidV1(input);
            Assert.Equal(expected, actual);
        }
    }
}