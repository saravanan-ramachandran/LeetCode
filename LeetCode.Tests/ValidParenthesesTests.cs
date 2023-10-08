using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Solution solution = new Solution();
            var actual = solution.IsValidV1(input);
            Assert.Equal(expected, actual);
        }
    }
}
