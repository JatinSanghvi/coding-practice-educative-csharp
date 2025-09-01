// Insert Interval
// ===============
//
// You are given a list of non-overlapping intervals, `intervals`, where each interval is represented as
// `[start_i, end_i]` and the list is sorted in ascending order by the start of each interval (`start_i`). You are
// also given another interval, `newInterval = [start, end]`.
//
// Your task is to insert `newInterval` into the list of intervals such that the list remains sorted by starting
// times and still contains no overlapping intervals. If any intervals overlap after the insertion, merge them
// accordingly.
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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N05_MergeIntervals.P02_InsertInterval;

public class Solution
{
    public static bool Function()
    {
        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(true);
    }

    private static void Run(bool expectedResult)
    {
        bool result = Solution.Function();
        Utilities.PrintSolution(true, result);
        Assert.AreEqual(expectedResult, result);
    }
}
