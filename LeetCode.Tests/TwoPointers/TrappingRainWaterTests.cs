using LeetCode.TwoPointers;

namespace LeetCode.Tests.TwoPointers;

public class TrappingRainWaterTests
{
    [Theory]
    [InlineData(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
    public void TrapV1(int[] nums, int expected)
    {
        Solution solution = new();
        int actual = solution.TrapV1(nums);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
    public void TrapV2(int[] nums, int expected)
    {
        Solution solution = new();
        int actual = solution.TrapV2(nums);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
    public void TrapV3(int[] nums, int expected)
    {
        Solution solution = new();
        int actual = solution.TrapV3(nums);
        Assert.Equal(expected, actual);
    }
}