// Minimum Time Takes to Reach Destination Without Drowning
// ========================================================
//
// Given a `m x n` grid of the string `land`. It consists of the following types of cells:
//
// - `S`: Source cell where you are standing initially.
// - `D`: Destination cell where you have to reach.
// - `.`: These cells are empty.
// - `X`: These cells are stone.
// - `*`: These cells are flooded.
//
// Each second, you can move to a neighboring cell directly next to your current one. At the same time, any empty cell
// next to a flooded cell also becomes flooded. There are two challenges in your path:
//
// 1. You can't step on stone cells.
// 2. You can't step on flooded cells or cells that will flood right when you try to step on them because you'll drown.
//
// Return the minimum time it takes you to reach the destination from the source in seconds, or -1 if no path exists
// between them.
//
// > Note: The destination will never be flooded.
//
// Constraints:
//
// - 2 ≤ `m`, `n` ≤ 100
// - `land` consists only of `S`, `D`, `.`, `*` and `X`.
// - There is only one `S` and `D` cell in the `land`.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N18_Matrices.P07_MinimumTimeTakesToReachDestinationWithoutDrowning;

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
