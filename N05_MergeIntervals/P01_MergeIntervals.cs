// Merge Intervals
// ===============
//
// We are given an array of closed intervals called `intervals`, where each interval has a start time and an end time
// and is represented as `intervals[i] = [start_i, end_i]`. Your task is to merge the overlapping intervals and return
// a new output array consisting of only the non-overlapping intervals.
//
// Constraints:
//
// - 1 ≤ intervals.length ≤ 10^3
// - intervals[i].length == 2
// - 0 ≤ start_i ≤ end_i ≤ 10^4

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N05_MergeIntervals.P01_MergeIntervals;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(1).
    public static int[][] MergeIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (x, y) => x[0] - y[0]);

        var merged = new List<int[]>();

        foreach (int[] interval in intervals)
        {
            if (merged.Count == 0 || merged.Last()[1] < interval[0])
            {
                merged.Add(interval);
            }
            else
            {
                merged.Last()[1] = Math.Max(merged.Last()[1], interval[1]);
            }
        }

        return merged.ToArray();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[5, 5], [3, 3], [2, 4], [1, 3]], [[1, 4], [5, 5]]);
    }

    private static void Run(int[][] intervals, int[][] expectedResult)
    {
        int[][] result = Solution.MergeIntervals(intervals);
        Utilities.PrintSolution(intervals, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
