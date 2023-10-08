using FluentAssertions;
using LeetCode.TwoPointers;
namespace LeetCode.Tests.TwoPointers
{
    public class ContainerWithMostWaterTests
    {
        [Theory]
        [InlineData(new int[] {1,8,6,2,5,4,8,3,7}, 49)]
        public void MaxAreaV1(int[] nums, int expected)
        {
            Solution solution = new Solution();
            var actual = solution.MaxAreaV1(nums);
            Assert.Equal(actual, expected);
        }
                [Theory]
        [InlineData(new int[] {1,8,6,2,5,4,8,3,7}, 49)]
        public void MaxAreaV2(int[] nums, int expected)
        {
            Solution solution = new Solution();
            var actual = solution.MaxAreaV2(nums);
            Assert.Equal(actual, expected);
        }

    }
}