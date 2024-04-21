using FluentAssertions;
using LeetCode.TwoPointers;

namespace LeetCode.Tests.TwoPointers
{
    public class TwoSumIITests
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        public void TwoSumTest(int[] nums, int target, int[] expected)
        {
            Solution solution = new();
            var actual = solution.TwoSum(nums, target);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}