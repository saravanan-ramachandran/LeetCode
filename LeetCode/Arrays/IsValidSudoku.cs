namespace LeetCode.Arrays
{
    public partial class Solution
    {
        public bool IsValidSudokuV1(char[][] board)
        {
            HashSet<char>[] rowHashs = new HashSet<char>[9];
            HashSet<char>[] colHashs = new HashSet<char>[9];
            HashSet<char>[,] squareHashes = new HashSet<char>[3, 3];
            for (int i = 0; i < rowHashs.Length; i++)
            {
                rowHashs[i] = new HashSet<char>();
                colHashs[i] = new HashSet<char>();
            }
            for (int i = 0; i < squareHashes.GetLength(0); i++)
            {
                for (int j = 0; j < squareHashes.GetLength(1); j++)
                {
                    squareHashes[i, j] = new HashSet<char>();
                }
            }
            for (int rows = 0; rows < board.Length; rows++)
            {
                for (int cols = 0; cols < board[rows].Length; cols++)
                {
                    if (board[rows][cols] == '.')
                    {
                        continue;
                    }
                    if (rowHashs[rows].Contains(board[rows][cols])
                        || colHashs[cols].Contains(board[rows][cols])
                        || squareHashes[rows / 3, cols / 3].Contains(board[rows][cols]))
                    {
                        return false;
                    }

                    rowHashs[rows].Add(board[rows][cols]);
                    colHashs[rows].Add(board[rows][cols]);
                    squareHashes[rows / 3, cols / 3].Add(board[rows][cols]);
                }
            }
            return true;
        }

        public bool IsValidSudokuV2(char[][] board)
        {
            HashSet<string> hashedBoard = new();
            char element;
            for (int rows = 0; rows < board.Length; rows++)
            {
                for (int cols = 0; cols < board[rows].Length; cols++)
                {
                    element = board[rows][cols];
                    if (element != '.')
                    {
                        if (!hashedBoard.Add($"{element} at rows {rows}")
                            || !hashedBoard.Add($"{element} at cols {cols}")
                            || !hashedBoard.Add($"{element} at sub square {rows / 3} - {cols / 3}"))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}