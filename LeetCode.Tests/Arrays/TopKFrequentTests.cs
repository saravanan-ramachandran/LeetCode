using FluentAssertions;
using LeetCode.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Arrays
{
    public class TopKFrequentTests
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 1, 2, 2, 3}, 2, new int[] {1, 2})]
        [InlineData(new int[] { 1 }, 1, new int[] { 1 })]
        public void TopKFrequentV1(int[] input, int k, int[] expected)
        {
            Solution solution = new Solution();
            var actual = solution.TopKFrequentV1(input, k);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new int[] { 1, 1, 1, 2, 2, 3 }, 2, new int[] { 1, 2 })]
        [InlineData(new int[] { 1 }, 1, new int[] { 1 })]
        public void TopKFrequentV2(int[] input, int k, int[] expected)
        {
            Solution solution = new Solution();
            var actual = solution.TopKFrequentV2(input, k);
            //Assert.Equal(expected, actual);
            expected.Should().BeEquivalentTo(actual);
        }

    }
}
