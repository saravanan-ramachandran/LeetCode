using LeetCode.Arrays;
namespace LeetCode.Tests.Arrays;

public class IsValidSudokuTests
{
    [Fact]
    public void IsValidSudokuV1_Returns_False()
    {
        char[][] sudokuBoard = new char[9][] 
        {
            new char[] { '1','2','3','4','5','6','7','8','9'},
            new char[] { '1','2','3','4','5','6','7','8','9'},
            new char[] { '1','2','3','4','5','6','7','8','9'},
            new char[] { '1','2','3','4','5','6','7','8','9'},
            new char[] { '1','2','3','4','5','6','7','8','9'},
            new char[] { '1','2','3','4','5','6','7','8','9'},
            new char[] { '1','2','3','4','5','6','7','8','9'},
            new char[] { '1','2','3','4','5','6','7','8','9'},
            new char[] { '1','2','3','4','5','6','7','8','9'}
        };

        Solution solution = new Solution();
        var expected = solution.IsValidSudokuV1(sudokuBoard);
        Assert.True(!expected);
    }
    [Fact]
    public void IsValidSudokuV1_Returns_True()
    {
        char[][] sudokuBoard = new char[9][]
        {
            new char[] { '6','3','9','5','7','4','1','8','2'},
            new char[] { '5','4','1','8','2','9','3','7','6'},
            new char[] { '7','8','2','6','1','2','9','5','4'},
            new char[] { '1','9','8','4','6','7','5','2','3'},
            new char[] { '3','6','5','9','8','2','4','1','7'},
            new char[] { '4','2','7','1','3','5','8','6','9'},
            new char[] { '9','5','6','7','4','8','2','3','1'},
            new char[] { '8','1','3','2','9','6','7','4','5'},
            new char[] { '2','7','4','3','5','1','6','9','8'}
        };
        Solution solution = new Solution();
        var expected = solution.IsValidSudokuV1(sudokuBoard);
        Assert.True(!expected);
    }
    [Fact]
    public void IsValidSudokuV2_Returns_False()
    {
        char[][] sudokuBoard = new char[9][]
        {
            new char[] { '1','2','3','4','5','6','7','8','9'},
            new char[] { '1','2','3','4','5','6','7','8','9'},
            new char[] { '1','2','3','4','5','6','7','8','9'},
            new char[] { '1','2','3','4','5','6','7','8','9'},
            new char[] { '1','2','3','4','5','6','7','8','9'},
            new char[] { '1','2','3','4','5','6','7','8','9'},
            new char[] { '1','2','3','4','5','6','7','8','9'},
            new char[] { '1','2','3','4','5','6','7','8','9'},
            new char[] { '1','2','3','4','5','6','7','8','9'}
        };

        Solution solution = new Solution();
        var expected = solution.IsValidSudokuV2(sudokuBoard);
        Assert.True(!expected);
    }
    [Fact]
    public void IsValidSudokuV2_Returns_True()
    {
        char[][] sudokuBoard = new char[9][]
        {
            new char[] { '6','3','9','5','7','4','1','8','2'},
            new char[] { '5','4','1','8','2','9','3','7','6'},
            new char[] { '7','8','2','6','1','2','9','5','4'},
            new char[] { '1','9','8','4','6','7','5','2','3'},
            new char[] { '3','6','5','9','8','2','4','1','7'},
            new char[] { '4','2','7','1','3','5','8','6','9'},
            new char[] { '9','5','6','7','4','8','2','3','1'},
            new char[] { '8','1','3','2','9','6','7','4','5'},
            new char[] { '2','7','4','3','5','1','6','9','8'}
        };
        Solution solution = new Solution();
        var expected = solution.IsValidSudokuV2(sudokuBoard);
        Assert.True(!expected);
    }
}