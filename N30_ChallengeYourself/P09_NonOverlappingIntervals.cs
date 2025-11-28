// Non-overlapping Intervals
// =========================
//
// Given an array of intervals where `intervals[i]` contains the half-open interval, (start_i,end_i], your task is to
// find the minimum number of intervals you need to remove to make the rest of the intervals non-overlapping.
//
// > Note: Two intervals (a,b] and (c,d] are considered overlapping if there exists a value x such that a < x ≤ b and c
// > < x ≤ d. In other words, if there is any point within both intervals (excluding their starting points) where both
// > intervals have values, they are considered overlapping. For example, the intervals (7,11] and (10,12] are
// > overlapping, whereas the intervals (2,4] and (4,5] are non-overlapping.
//
// Constraints:
//
// - 1 ≤ `intervals.length` ≤ 10^3
// - `intervals[i].length` == 2
// - -5×10^4 ≤ start_i < end_i ≤ 5×10^4

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P09_NonOverlappingIntervals;

public class Solution
{
    public static int RemoveMinIntervals(int[][] intervals)
    {
        intervals = intervals.OrderBy(i => i[0]).ToArray();

        int refTime = int.MaxValue;
        int removals = -1;

        foreach (int[] interval in intervals)
        {
            if (interval[0] < refTime)
            {
                removals++;
                refTime = Math.Min(refTime, interval[1]);
            }
            else
            {
                refTime = interval[1];
            }
        }

        return removals;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 2], [2, 3], [3, 4], [1, 4]], 1);
        Run([[1, 3], [2, 4], [3, 5], [4, 6]], 2);
        Run([[1, 7], [2, 6], [3, 5], [4, 4]], 3);
    }

    private static void Run(int[][] intervals, int expectedResult)
    {
        int result = Solution.RemoveMinIntervals(intervals);
        Utilities.PrintSolution(intervals, result);
        Assert.AreEqual(expectedResult, result);
    }
}
