// K Closest Points to Origin
// ==========================
//
// You are given an array of points where each element `points[i]` = [x_i, y_i] represents a point on the X-Y plane,
// along with an integer `k`. Your task is to find and return the `k` points that are closest to the origin [0, 0].
//
// The distance between two points on the X-Y plane is measured using Euclidean distance, which is calculated as:
//
// ((x_2 - x_1)^2 + (y_2 - y_1)^2)^0.5
//
// > Note: You can return the result in any order. The answer is guaranteed to be unique, except for the order in which
// > points appear.
//
// Constraints:
//
// - 1 ≤ k ≤ `points.length` ≤ 10^3
// - -10^4 ≤ x_i, y_i ≤ 10^4

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P03_KClosestPointsToOrigin;

public class Solution
{
    // Time complexity: O(p*logk), Space complexity: O(k).
    public int[][] KClosest(int[][] points, int k)
    {
        var distanceQueue = new PriorityQueue<(int, int), double>();

        foreach (int[] point in points)
        {
            int x = point[0];
            int y = point[1];

            double squareDistance = Math.Pow(x, 2) + Math.Pow(y, 2);
            distanceQueue.Enqueue((x, y), -squareDistance);
            if (distanceQueue.Count > k)
            {
                distanceQueue.Dequeue();
            }
        }

        return distanceQueue.UnorderedItems
            .Select(item => new int[] { item.Element.Item1, item.Element.Item2 })
            .ToArray();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 2], [2, -2], [-1, -1]], 2, [[1, 2], [-1, -1]]);
    }

    private static void Run(int[][] points, int k, int[][] expectedResult)
    {
        int[][] result = new Solution().KClosest(points, k);
        Utilities.PrintSolution((points, k), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
