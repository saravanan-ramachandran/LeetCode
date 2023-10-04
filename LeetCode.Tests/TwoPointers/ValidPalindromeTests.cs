using LeetCode.TwoPointers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Solution solution = new Solution();
            var actual = solution.IsPalindrome(input);
            Assert.Equal(expected, actual);
        }
    }
}
