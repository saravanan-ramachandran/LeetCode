using LeetCode.Arrays;
namespace LeetCode.Tests.Arrays;
public class GroupAnagramsTests
{
    [Fact]
    public void GroupAnagramsTestsV1()
    {
        string[] strs = new string[] {"eat", "tea", "tan", "ate", "nat", "bat"};
        Solution solution = new();
        var result = solution.GroupAnagramsV1(strs);
    }
    [Fact]
    public void GroupAnagramsTestsV2()
    {
        string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        Solution solution = new();
        var result = solution.GroupAnagramsV2(strs);
    }
}
