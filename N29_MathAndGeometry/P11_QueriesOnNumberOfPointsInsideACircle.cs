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

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P11_QueriesOnNumberOfPointsInsideACircle;

public class Solution
{
    // Time complexity: O(mn), Space complexity: O(1).
    public static int[] CountPoints(int[][] points, int[][] queries)
    {
        var counts = new List<int>();

        foreach (int[] query in queries)
        {
            (int cx, int cy, int r) = (query[0], query[1], query[2]);

            int count = 0;
            foreach (int[] point in points)
            {
                (int px, int py) = (point[0], point[1]);
                (int dx, int dy) = (px - cx, py - cy);

                if (dx * dx + dy * dy <= r * r) { count++; }
            }

            counts.Add(count);
        }

        return counts.ToArray();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[0, 0], [1, 0], [0, 1], [1, 1]], [[0, 0, 1], [0, 1, 1], [0, 2, 1]], [3, 3, 1]);
    }

    private static void Run(int[][] points, int[][] queries, int[] expectedResult)
    {
        int[] result = Solution.CountPoints(points, queries);
        Utilities.PrintSolution((points, queries), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
