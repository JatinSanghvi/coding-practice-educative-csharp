// Minimize Manhattan Distances
// ============================
//
// You are given an array, `points`, where each element in `points[i]` = [x_j, y_i] represents the integer coordinates
// of a point in a 2D plane. The distance between any two points is defined as the Manhattan distance.
//
// Your task is to determine and return the smallest possible value for the maximum distance between any two points
// after removing exactly one point from the array.
//
// Constraints:
//
// - 3 ≤ `points.length` ≤ 10^3
// - `points[i].length` == 2
// - 1 ≤ `points[i][0]`, `points[i][1]` ≤ 10^3

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P14_MinimizeManhattanDistances;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public int MinimumDistance(int[][] points)
    {
        // Manhattan distance == |x2 - x1| + |y2 - y1| == max(|s2 - s1|, |d2 - d1|) where sk = xk + yk and dk = xk - yk.
        // This reduces the computation, since instead of checking distances between each pair of points, we only need
        // to track extreme values of s2, s1, d2, d1 across all points.

        int maxSum1, maxSum2, maxDiff1, maxDiff2;
        int minSum1, minSum2, minDiff1, minDiff2;

        maxSum1 = maxSum2 = maxDiff1 = maxDiff2 = int.MinValue;
        minSum1 = minSum2 = minDiff1 = minDiff2 = int.MaxValue;

        int maxSum1Index, minSum1Index, maxDiff1Index, minDiff1Index;
        maxSum1Index = minSum1Index = maxDiff1Index = minDiff1Index = -1;

        for (int i = 0; i != points.Length; i++)
        {
            (int x, int y) = (points[i][0], points[i][1]);

            int sum = x + y;
            int diff = x - y;

            if (maxSum1 < sum) { (maxSum1, maxSum1Index, maxSum2) = (sum, i, maxSum1); }
            else if (maxSum2 < sum) { maxSum2 = sum; }

            if (maxDiff1 < diff) { (maxDiff1, maxDiff1Index, maxDiff2) = (diff, i, maxDiff1); }
            else if (maxDiff2 < diff) { maxDiff2 = diff; }

            if (minSum1 > sum) { (minSum1, minSum1Index, minSum2) = (sum, i, minSum1); }
            else if (minSum2 > sum) { minSum2 = sum; }

            if (minDiff1 > diff) { (minDiff1, minDiff1Index, minDiff2) = (diff, i, minDiff1); }
            else if (minDiff2 > diff) { minDiff2 = diff; }
        }

        var candidates = new[] { maxSum1Index, maxDiff1Index, minSum1Index, minDiff1Index };
        int minDistance = int.MaxValue;
        foreach (int i in candidates)
        {
            if (i == -1) { continue; }

            int maxSum = i != maxSum1Index ? maxSum1 : maxSum2;
            int minSum = i != minSum1Index ? minSum1 : minSum2;
            int maxDiff = i != maxDiff1Index ? maxDiff1 : maxDiff2;
            int minDiff = i != minDiff1Index ? minDiff1 : minDiff2;

            minDistance = Math.Min(minDistance, Math.Max(maxSum - minSum, maxDiff - minDiff));
        }

        return minDistance;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 2], [-2, 1], [-1, -2], [2, -1]], 6);
        Run([[1, 1], [-2, 2], [-3, -3], [4, -4]], 8);
    }

    private static void Run(int[][] points, int expectedResult)
    {
        int result = new Solution().MinimumDistance(points);
        Utilities.PrintSolution(points, result);
        Assert.AreEqual(expectedResult, result);
    }
}
