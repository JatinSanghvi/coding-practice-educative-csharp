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

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P17_MinimumNumberOfLinesToCoverPoints;

public class Solution
{
    public int MinimumLines(int[][] points)
    {
        throw new NotImplementedException();
    }
}

internal static class Tests
{
    public static void Run()
    {
        // x _ _ _
        // x x _ _
        // X _ x _
        // x X X X
        Run([[3, 0], [2, 0], [2, 1], [1, 0], [1, 2], [0, 0], [0, 1], [0, 2], [0, 3]], 3);
    }

    private static void Run(int[][] points, int expectedResult)
    {
        Assert.Throws<NotImplementedException>(() => new Solution().MinimumLines(points));

        // int result = new Solution().MinimumLines(points);
        // Utilities.PrintSolution(points, result);
        // CollectionAssert.AreEqual(expectedResult, result);
    }
}
