// Best Meeting Point
// ==================
//
// You are given a 2D grid of size m × n, where each cell contains either a 0 or a 1.
//
// A 1 represents the home of a friend, and a 0 represents an empty space.
//
// Your task is to return the minimum total travel distance to a meeting point. The total travel distance is the sum of
// the Manhattan distances between each friend's home and the meeting point.
//
// The Manhattan Distance between two points `(x1, y1)` and `(x2, y2)` is calculated as:
// `|x2 - x1| + |y2 - y1|`.
//
// Constraints:
//
// - m == `grid.length`
// - n == `grid[i].length`
// - 1 ≤ m, n ≤ 50
// - `grid[i][j]` is either `0` or `1`.
// - There will be at least two friends in the `grid`.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N18_Matrices.P17_BestMeetingPoint;

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
