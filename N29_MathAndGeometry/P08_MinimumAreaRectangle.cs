// Minimum Area Rectangle
// ======================
//
// You are given an array of points, where `point[i]` = [x_i, y_i] represents a point on a 2D plane.
//
// Your task is to determine the minimum area of a rectangle that can be formed using any four points where the
// rectangle's sides are aligned parallel to the X and Y axes. If no such rectangle can be formed, return 0.
//
// Constraints:
//
// - 1 ≤ `points.length` ≤ 500
// - `points[i].length` == 2
// - 0 ≤ x_i, y_i ≤ 10^3
// - All given points are unique.

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P08_MinimumAreaRectangle;

public class Solution
{
    // Time complexity: O(n^2), Space complexity: O(n).
    public int MinAreaRect(int[][] points)
    {
        var pointSet = new HashSet<(int, int)>();

        foreach (int[] point in points)
        {
            pointSet.Add((point[0], point[1]));
        }

        int area = int.MaxValue;
        for (int i = 0; i != points.Length; i++)
        {
            for (int j = i + 1; j != points.Length; j++)
            {
                if (
                    points[i][0] != points[j][0] &&
                    points[i][1] != points[j][1] &&
                    pointSet.Contains((points[i][0], points[j][1])) &&
                    pointSet.Contains((points[j][0], points[i][1])))
                {
                    area = Math.Min(area, Math.Abs((points[j][0] - points[i][0]) * (points[j][1] - points[i][1])));
                }
            }
        }

        return area == int.MaxValue ? 0 : area;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[0, 0], [0, 3], [0, 5], [3, 0], [3, 3], [3, 5], [5, 0], [5, 3], [5, 5]], 4);
        Run([[6, 3], [8, 3], [9, 3], [9, 7], [8, 7], [6, 7]], 4);
    }

    private static void Run(int[][] points, int expectedResult)
    {
        int result = new Solution().MinAreaRect(points);
        Utilities.PrintSolution(points, result);
        Assert.AreEqual(expectedResult, result);
    }
}
