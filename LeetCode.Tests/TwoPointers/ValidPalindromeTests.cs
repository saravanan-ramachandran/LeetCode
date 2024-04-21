using LeetCode.TwoPointers;

namespace LeetCode.Tests.TwoPointers
{
    public class ValidPalindromeTests
    {
        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("A Race CAr", false)]
        [InlineData("    ", true)]
        public void IsValidPalindrome(string input, bool expected)
        {
            Solution solution = new();
            var actual = solution.IsPalindrome(input);
            Assert.Equal(expected, actual);
        }
    }
}