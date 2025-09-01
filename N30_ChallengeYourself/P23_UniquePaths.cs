// Unique Paths
// ============
//
// Imagine a scenario where an adventurous little robot, named Robi, has a mission to traverse a grid with `m` rows and
// `n` columns and reach a treasure box placed at grid[m-1][n-1]. Robi starts the journey from its home in the top-left
// corner of the grid, grid[0][0]. However, it faces a constraint that at any given time, it can only move in either of
// the two directions: downward or to the right.
//
// Given the two integers, `m` and `n`, return the total number of unique paths that Robi can take from the grid's
// top-left corner to reach the bottom-right corner of the grid.
//
// Constraints:
//
// - 1 ≤ `m`, `n` ≤ 100

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P23_UniquePaths;

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
