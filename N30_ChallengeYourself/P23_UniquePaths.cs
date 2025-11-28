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
    // Time complexity: O(m + n), Space complexity: O(1).
    public static int UniquePaths(int m, int n)
    {
        long result = 1;

        // Compute (m + n - 2) choose (m - 1).
        for (int numerator = n; numerator != m + n - 1; numerator++)
        {
            int denominator = numerator - n + 1;
            result = result * numerator / denominator;
        }

        return (int)result;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(1, 2, 1);
        Run(3, 2, 3);
        Run(3, 4, 10);
        Run(100, 7, 1609344100); // 100, 8 would exceed integer limit.
    }

    private static void Run(int m, int n, int expectedResult)
    {
        int result = Solution.UniquePaths(m, n);
        Utilities.PrintSolution((m, n), result);
        Assert.AreEqual(expectedResult, result);
    }
}
