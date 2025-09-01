// Convex Polygon
// ==============
//
// You are given an array of points on the XY plane, where each point is represented as `points[i]` = [x_i, y_i]. These
// points, when connected sequentially, form a polygon.
//
// Your task is to return TRUE if the polygon is convex and FALSE otherwise.
//
// > Note: It is guaranteed that the polygon formed by the given points is simple, meaning exactly two edges intersect
// > at each vertex, and the edges do not intersect with each other elsewhere.
//
// Constraints:
//
// - 3 ≤ `points.length` ≤ 10^3
// - `points[i].length` == 2
// - -10^4 ≤ x_i, y_i ≤ 10^4
// - All the given points are unique.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P10_ConvexPolygon;

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
