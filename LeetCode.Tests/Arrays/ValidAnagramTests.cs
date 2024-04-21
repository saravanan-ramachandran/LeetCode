using LeetCode.Arrays;

namespace LeetCode.Tests.Arrays
{
    public class ValidAnagramTests
    {
        [Theory]
        [InlineData("anagram", "nagaram", true)]
        [InlineData("rat", "car", false)]
        public void IsValidAnagramTestsV1(string a, string b, bool expected)
        {
            Solution solution = new();
            var actual = solution.IsValidAnagramV1(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("anagram", "nagaram", true)]
        [InlineData("rat", "car", false)]
        public void IsValidAnagramTestsV2(string a, string b, bool expected)
        {
            Solution solution = new();
            var actual = solution.IsValidAnagramV2(a, b);
            Assert.Equal(expected, actual);
        }
    }
}