using LeetCode.Stack;

namespace LeetCode.Tests.Stack
{
    public class ReversePolishNotationTests
    {
        [Theory]
        [InlineData(new string[] { "2", "1", "+", "3", "*" }, 9)]
        public void EvalRPNTest(string[] input, int expected)
        {
            Solution solution = new();
            int actual = solution.EvalRPN(input);
            Assert.Equal(expected, actual);
        }
    }
}