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

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P10_ConvexPolygon;

public class Solution
{
    public static bool IsConvex(IList<IList<int>> points)
    {
        // Find sign of cross product and compare if for each set of 3 points.
        int crossProduct =
            (points[1][0] - points[0][0]) * (points[2][1] - points[1][1]) -
            (points[1][1] - points[0][1]) * (points[2][0] - points[1][0]);

        points.Add(points[0]);
        points.Add(points[1]);
        for (int i = 0; i != points.Count - 2; i++)
        {
            int currCrossProduct =
                (points[i + 1][0] - points[i][0]) * (points[i + 2][1] - points[i + 1][1]) -
                (points[i + 1][1] - points[i][1]) * (points[i + 2][0] - points[i + 1][0]);

            if (crossProduct * currCrossProduct < 0)
            {
                return false;
            }
        }

        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[0, 0], [1, 1], [1, 2], [0, 3], [-1, 2], [-1, 1]], true);
        Run([[0, 0], [1, 1], [2, 0], [1, 3]], false);
    }

    private static void Run(int[][] points, bool expectedResult)
    {
        bool result = Solution.IsConvex(points.Select(p => (IList<int>)p.ToList()).ToList());
        Utilities.PrintSolution(points, result);
        Assert.AreEqual(expectedResult, result);
    }
}
