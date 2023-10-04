using LeetCode.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Arrays
{
    public class ProductExceptSelfTests
    {
        [Theory]
        [InlineData(new int[] {1, 2, 3, 4}, new int[] {24, 12, 8, 6})]
        public void ProductExceptSelfTestsV3(int[] nums, int[] expected)
        {
            Solution solution = new();
            var actual = solution.ProductExceptSelfV3(nums);
            Assert.Equal(expected, actual);
        }
    }
}
