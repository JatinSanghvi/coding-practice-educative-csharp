// Word Search II
// ==============
//
// You are given a list of strings that you need to find in a 2D grid of letters such that the string can be constructed
// from letters in sequentially adjacent cells. The cells are considered sequentially adjacent when they are neighbors
// to each other either horizontally or vertically. The solution should return a list containing the strings from the
// input list that were found in the grid.
//
// Constraints:
//
// - 1 ≤ rows, columns ≤ 12
// - 1 ≤ `words.length` ≤ 3×10^3
// - 1 ≤ `words[i].length` ≤ 10
// - `grid[i][j]` is an uppercase English letter.
// - `words[i]` consists of uppercase English letters.
// - All the strings are unique.
//
// > Note: The order of the strings in the output does *not* matter.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P05_WordSearchII;

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
