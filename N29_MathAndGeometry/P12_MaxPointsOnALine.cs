// Max Points on a Line
// ====================
//
// Given an integer array of `points` where `points[i]` = [x_i, y_i] represents a point on the X--Y plane, your task is
// to return the maximum number of points on the same straight line.
//
// Constraints:
//
// - 1 ≤ `points.length` ≤ 300
// - `points[i].length` = 2
// - -10^4 ≤ x_i, y_i ≤ 10^4
// - All the points are unique.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P12_MaxPointsOnALine;

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
