// Rotting Oranges
// ===============
//
// Consider an m×n grid containing cells with three potential values:
//
// - 0,which indicates an unoccupied cell.
//
// - 1,representing a freshly picked orange.
//
// - 2, indicating a rotten orange.
//
// Any fresh orange that is 4--directionally adjacent to a rotten orange will also turn rotten with each passing minute.
//
// Your task is to determine the minimum time required for all cells to have rotten oranges. In case, this objective
// cannot be achieved, return -1.
//
// Constraints:
//
// - `m` = `grid.length`
//
// - `n` = `grid[i].length`
//
// - 1 ≤ `m`, `n` ≤ 10
//
// - `grid[i][j]` is `0`, `1`, or `2`.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P37_RottingOranges;

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
