// Minimum Time Visiting All Points
// ================================
//
// You are given an array of n points with integer coordinates on a 2D plane, `points`, where points[i]=[xi​,yi​]. Your
// task is to determine the minimum time in seconds required to visit all the points in the given order.
//
// Movement rules:
//
// 1. In one second, you can perform any one of the following:
//     1. Move vertically by one unit.
//     2. Move horizontally by one unit.
//     3. Move diagonally (1 unit vertically and 1 unit horizontally in 1 second).
// 2. You must visit the points in the exact sequence listed in the array.
// 3. You may pass through points that appear later in the order, but they will not count as visits.
//
// Constraints:
//
// - `points.length` = n
// - 1 ≤ n ≤ 10^2
// - `points[i].length` = 2
// - -10^3 ≤ `points[i][0]`, `points[i][1]` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P04_MinimumTimeVisitingAllPoints;

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
