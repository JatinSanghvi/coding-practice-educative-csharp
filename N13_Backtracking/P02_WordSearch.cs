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
    public static bool Function()
    {
        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(true);
    }

    private static void Run(bool expectedResult)
    {
        bool result = Solution.Function();
        Utilities.PrintSolution(true, result);
        Assert.AreEqual(expectedResult, result);
    }
}
