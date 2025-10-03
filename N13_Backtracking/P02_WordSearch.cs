// Word Search
// ===========
//
// Given an `m x n` grid of characters, `board`, and a string `word`, return TRUE if `word` exists in the grid.
//
// The word can be formed by connecting letters of sequentially adjacent cells. The cells are considered sequentially
// adjacent when neighbors are either horizontally or vertically neighbors. Each cell can be used only once while
// forming the word.
//
// Constraints:
//
// - `m` == `board.length`
// - `n` == `board[i].length`, where 0 ≤ `i` < `m`
// - 1 ≤ `m, n` ≤ 6
// - 1 ≤ `word.length` ≤ 15
// - `board` and `word` consist of only lowercase and uppercase English letters.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P02_WordSearch;

public class Solution
{
    // Time complexity: O(mn*4^i), Space complexity: O(mn + i);
    public static bool WordSearch(char[][] grid, string word)
    {
        int rows = grid.Length, cols = grid[0].Length;
        var visited = new bool[rows, cols];

        for (int m = 0; m < rows; m++)
        {
            for (int n = 0; n < cols; n++)
            {
                if (Solve(m, n, 0)) { return true; }
            }
        }

        return false;

        bool Solve(int m, int n, int i)
        {
            if (i == word.Length)
            {
                return true;
            }

            if (m == -1 || m == rows || n == -1 || n == cols || grid[m][n] != word[i] || visited[m, n])
            {
                return false;
            }

            visited[m, n] = true;
            bool result = Solve(m, n - 1, i + 1) || Solve(m, n + 1, i + 1) || Solve(m - 1, n, i + 1) || Solve(m + 1, n, i + 1);
            visited[m, n] = false;

            return result;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([['O', 'L'], ['X', 'O'], ['X', 'S']], "SOLO", true);
        Run([['X', 'L'], ['X', 'O'], ['X', 'S']], "SOLO", false);
    }

    private static void Run(char[][] grid, string word, bool expectedResult)
    {
        bool result = Solution.WordSearch(grid, word);
        Utilities.PrintSolution((grid, word), result);
        Assert.AreEqual(expectedResult, result);
    }
}
