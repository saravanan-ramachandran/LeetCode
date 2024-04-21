using FluentAssertions;
using LeetCode.TwoPointers;

namespace LeetCode.Tests.TwoPointers
{
    public class ThreeSumTests
    {
        [Fact]
        public void ThreeSumV3()
        {
            var input = new int[] { -1, 0, 1, 2, -1, -4 };

            List<List<int>> expected = new();

            expected.Add(new List<int> { -1, -1, 2 });
            expected.Add(new List<int> { -1, 0, 1 });

            Solution solution = new();
            var actual = solution.ThreeSumV3(input);
            expected.Should().BeEquivalentTo(actual);
        }
    }
}