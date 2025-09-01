// Queries on Number of Points Inside a Circle
// ===========================================
//
// Given an array of points, where each point is represented as `points[i]` = [x_i, y_i], which are the coordinates of
// the i_th point on an X-Y plane where some points may have identical coordinates. Additionally, given an array of
// queries, where each `queries[j]` = [x_j, y_j, r_j] represents a circle centered at the point [x_j, y_j] with a radius
// r_j.
//
// For each query, your task is to determine how many points lie within or on the boundary of the specified circle. The
// function should return an array `answer`, where `answer[j]` holds the number of points inside the j_th circle.
//
// > Note: Points on the circle's edge should also be counted inside the circle.
//
// Constraints:
//
// - 1 ≤ `points.length` ≤ 100
// - `points[i].length` == 2
// - 0 ≤ x_i, y_i ≤ 100
// - 1 ≤ `queries.length` ≤ 100
// - `queries[j].length` == 3
// - 0 ≤ x_j, y_j ≤ 100
// - 1 ≤ r_j ≤ 100

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P11_QueriesOnNumberOfPointsInsideACircle;

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
