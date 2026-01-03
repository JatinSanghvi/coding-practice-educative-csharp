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

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P12_MaxPointsOnALine;

public class Solution
{
    // Time complexity: O(n^2), Space complexity: O(n).
    public int MaxPoints(int[][] points)
    {
        int maxPoints = 1;

        for (int i = 0; i != points.Length; i++)
        {
            var slopes = new Dictionary<double, int>();
            for (int j = i + 1; j != points.Length; j++)
            {
                double slope = (double)(points[j][1] - points[i][1]) / (points[j][0] - points[i][0]);
                if (slope == double.NegativeInfinity) { slope = double.PositiveInfinity; }
                if (!slopes.ContainsKey(slope)) { slopes[slope] = 1; }
                slopes[slope]++;
                maxPoints = Math.Max(maxPoints, slopes[slope]);
            }
        }

        return maxPoints;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[0, 0], [0, 1], [0, -1], [0, -2], [1, 0], [-1, 0]], 4);
    }

    private static void Run(int[][] points, int expectedResult)
    {
        int result = new Solution().MaxPoints(points);
        Utilities.PrintSolution(points, result);
        Assert.AreEqual(expectedResult, result);
    }
}
