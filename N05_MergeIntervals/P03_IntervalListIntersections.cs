// Interval List Intersections
// ===========================
//
// Given two lists of closed intervals, `intervalLista` and `intervalListb`, return the intersection of the two interval
// lists.
//
// Each interval in the lists has its own start and end time and is represented as `[start, end]`. Specifically:
//
// - intervalLista[i] = [start_i, end_i]
// - intervalListb[j] = [start_j, end_j]
//
// The intersection of two closed intervals `i` and `j` is either:
//
// - An empty set, if they do not overlap, or
// - A closed interval `[max(start_i, start_j), min(end_i, end_j)]` if they do overlap.
//
// Also, each list of intervals is pairwise disjoint and in sorted order.
//
// Constraints:
//
// - 0 ≤ intervalLista.length, intervalListb.length ≤ 1000
// - intervalLista.length + intervalListb.length >= 1
// - 0 ≤ start_i < end_i ≤ 10^9
// - end_i < start_i + 1
// - 0 ≤ start_j < end_j ≤ 10^9
// - end_j < start[j + 1]

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N05_MergeIntervals.P03_IntervalListIntersections;

public class Solution
{
     // Time complexity: O(a+b), Space complexity: O(1).
    public static int[][] IntervalsIntersection(int[][] intervalLista, int[][] intervalListb)
    {
        var intersection = new List<int[]>();

        // Since the pairs are disjoint, the intersections will be disjoint too, so there is no need to merge them.
        int a = 0, b = 0;
        while (a < intervalLista.Length && b < intervalListb.Length)
        {
            // Overlap test.
            if (intervalLista[a][1] >= intervalListb[b][0] && intervalLista[a][0] <= intervalListb[b][1])
            {
                intersection.Add(new int[]
                {
                    Math.Max(intervalLista[a][0], intervalListb[b][0]),
                    Math.Min(intervalLista[a][1], intervalListb[b][1])
                });
            }

            // Skip the interval that ends sooner.
            if (intervalLista[a][1] <= intervalListb[b][1]) { a++; }
            else { b++; }
        }

        return intersection.ToArray();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(
            [[1, 2], [4, 5], [7, 8], [10, 11], [13, 14], [16, 17]],
            [[2, 3], [6, 7], [11, 16]],
            [[2, 2], [7, 7], [11, 11], [13, 14], [16, 16]]);
    }

    private static void Run(int[][] intervalLista, int[][] intervalListb, int[][] expectedResult)
    {
        int[][] result = Solution.IntervalsIntersection(intervalLista, intervalListb);
        Utilities.PrintSolution((intervalLista, intervalListb), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
