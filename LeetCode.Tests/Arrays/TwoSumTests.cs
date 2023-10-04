using FluentAssertions;
using LeetCode.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Arrays
{
    public class TwoSumTests
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSumTestsV1(int[] input, int target, int[] expected)
        {
            Solution solution = new Solution();
            var actual = solution.TwoSumV1(input, target);
            actual.Should().BeEquivalentTo(expected);
        }
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSumTestsV2(int[] input, int target, int[] expected)
        {
            Solution solution = new Solution();
            var actual = solution.TwoSumV2(input, target);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
