// Insert Interval
// ===============
//
// You are given a list of non-overlapping intervals, `intervals`, where each interval is represented as
// `[start_i, end_i]` and the list is sorted in ascending order by the start of each interval (`start_i`). You are also
// given another interval, `newInterval = [start, end]`.
//
// Your task is to insert `newInterval` into the list of intervals such that the list remains sorted by starting times
// and still contains no overlapping intervals. If any intervals overlap after the insertion, merge them accordingly.
//
// Return the updated list of intervals.
//
// > Note: You don't need to modify `intervals` in place. You can make a new array and return it.
//
// Constraints:
//
// - 0 ≤ intervals.length ≤ 10^4
// - intervals[i].length, newInterval.length == 2
// - 0 ≤ start_i < end_i ≤ 10^4
// - The list of intervals is sorted in ascending order based on the start time.

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N05_MergeIntervals.P02_InsertInterval;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1) if space required to store output is excluded.
    public static int[][] InsertInterval(int[][] existingIntervals, int[] newInterval)
    {
        var intervals = new List<int[]>();
        int i = 0;

        // Intervals before new interval.
        while (i < existingIntervals.Length && existingIntervals[i][1] < newInterval[0])
        {
            intervals.Add(existingIntervals[i]);
            i++;
        }

        int start = i == existingIntervals.Length ? newInterval[0] : Math.Min(existingIntervals[i][0], newInterval[0]);

        // Intervals overlapping new interval.
        while (i < existingIntervals.Length && existingIntervals[i][0] <= newInterval[1])
        {
            i++;
        }

        int end = i == 0 ? newInterval[1] : Math.Max(existingIntervals[i - 1][1], newInterval[1]);
        intervals.Add(new int[] { start, end });

        // Intervals after new interval.
        while (i < existingIntervals.Length)
        {
            intervals.Add(existingIntervals[i]);
            i++;
        }

        return intervals.ToArray();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[2, 4], [6, 8]], [0, 1], [[0, 1], [2, 4], [6, 8]]);
        Run([[2, 4], [6, 8]], [1, 2], [[1, 4], [6, 8]]);
        Run([[2, 4], [6, 8]], [4, 6], [[2, 8]]);
        Run([[2, 4], [6, 8]], [1, 9], [[1, 9]]);
    }

    private static void Run(int[][] existingIntervals, int[] newInterval, int[][] expectedResult)
    {
        int[][] result = Solution.InsertInterval(existingIntervals, newInterval);
        Utilities.PrintSolution((existingIntervals, newInterval), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
