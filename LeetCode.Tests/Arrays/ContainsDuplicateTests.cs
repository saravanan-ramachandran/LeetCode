using LeetCode.Arrays;

namespace LeetCode.Tests.Arrays;

public class ContainsDuplicateTests
{
    [Theory]
    [InlineData(new int[] { }, false)]
    [InlineData(new int[] { 1, 2, 3, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    public void ContainsDuplicateTestsV1(int[] nums, bool isDuplicate)
    {
        Solution solution = new();
        var hasDuplicate = solution.ContainsDuplicateV1(nums);

        Assert.True(hasDuplicate == isDuplicate);
    }

    [Theory]
    [InlineData(new int[] { }, false)]
    [InlineData(new int[] { 1, 2, 3, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    public void ContainsDuplicateTestsV2(int[] nums, bool isDuplicate)
    {
        Solution solution = new();
        var hasDuplicate = solution.ContainsDuplicateV2(nums);

        Assert.True(hasDuplicate == isDuplicate);
    }

    [Theory]
    [InlineData(new int[] { }, false)]
    [InlineData(new int[] { 1, 2, 3, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    public void ContainsDuplicateTestsV3(int[] nums, bool isDuplicate)
    {
        Solution solution = new();
        var hasDuplicate = solution.ContainsDuplicateV3(nums);

        Assert.True(hasDuplicate == isDuplicate);
    }
}