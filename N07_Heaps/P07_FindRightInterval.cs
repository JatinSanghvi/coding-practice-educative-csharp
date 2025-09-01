// Find Right Interval
// ===================
//
// You are given an array of `intervals` where each interval is represented by a pair [start_i, end_i]. The start_i
// values are unique, meaning no two intervals begin at the same time.
//
// The task is to find the right interval for each interval in the list. The right interval for an interval i is an
// interval j such that start_j ≥ end_i and start_j is minimized (i.e., it is the smallest start time among all valid
// intervals that is greater than or equal to end_i). Note that i may equal j.
//
// Return an array of right interval indexes for each interval i. If no right interval exists for interval i, then put -1
// at index i.
//
// Constraints:
//
// - 1 ≤ `intervals.length` ≤ 1000
// - `intervals[i].length` == 2
// - -10^6 ≤ start_i ≤ end_i ≤ 10^6
// - The start times are guaranteed to be unique.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P07_FindRightInterval;

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
