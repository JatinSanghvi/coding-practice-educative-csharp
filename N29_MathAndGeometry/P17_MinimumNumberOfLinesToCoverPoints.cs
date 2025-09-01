// Minimum Number of Lines to Cover Points
// =======================================
//
// Given a 2D integer array, `points`, where `points[i]` = [x_i, y_i] represents a point on an XY plane, find the
// minimum number of straight lines required to cover all the points.
//
// > Note: Straight lines will be added to the XY plane to ensure that every point is covered by at least one line.
//
// Constraints:
//
// - 1 ≤ `points.length` ≤ 10
// - `points[i].length` == 2
// - -100 ≤ x_i, y_i ≤ 100
// - All the points are unique.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P17_MinimumNumberOfLinesToCoverPoints;

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
