// Maximum Area Rectangle With Point Constraints I
// ===============================================
//
// You are given an array of `points`, where `points[i]` have two values: [x_i, y_i], representing its position on a
// flat plane.
//
// Your goal is to find the largest rectangle (having maximum area) that can be formed using any four points as the
// corners. The rectangle should meet the following conditions:
//
// - It has its borders parallel to the axes.
// - It should not contain any other points inside or along its border.
//
// Return the area of the largest rectangle you can create. If no such rectangle can be formed, return -1.
//
// Constraints:
//
// - 1 ≤ `points.length` ≤ 10
// - `points[i].length` = 2
// - 0 ≤ x_i, y_i ≤ 100
// - All the given points are unique.

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N29_MathAndGeometry.P09_MaximumAreaRectangleWithPointConstraintsI;

public class Solution
{
    // Time complexity: O(n^3), Space complexity: O(n).
    public int MaxRectangleArea(int[][] points)
    {
        var pointSet = new HashSet<(int, int)>();
        foreach (int[] point in points)
        {
            pointSet.Add((point[0], point[1]));
        }

        int maxArea = -1;
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
                    bool containsPoint = false;
                    foreach (int[] point in points)
                    {
                        if (
                            point[0] > Math.Min(points[i][0], points[j][0]) &&
                            point[0] < Math.Max(points[i][0], points[j][0]) &&
                            point[1] > Math.Min(points[i][1], points[j][1]) &&
                            point[1] < Math.Max(points[i][1], points[j][1]))
                        {
                            containsPoint = true;
                            break;
                        }
                    }

                    if (!containsPoint)
                    {
                        int area = Math.Abs((points[i][0] - points[j][0]) * (points[i][1] - points[j][1]));
                        maxArea = Math.Max(maxArea, area);
                    }
                }
            }
        }

        return maxArea;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[0, 0], [0, 3], [3, 0], [3, 3], [2, 2], [2, 4], [4, 2], [4, 4]], -1);
        Run([[0, 0], [0, 3], [3, 0], [3, 3], [1, 1], [1, 3], [3, 1]], 4);
    }

    private static void Run(int[][] points, int expectedResult)
    {
        int result = new Solution().MaxRectangleArea(points);
        Utilities.PrintSolution(points, result);
        Assert.AreEqual(expectedResult, result);
    }
}
