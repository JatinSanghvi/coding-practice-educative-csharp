// Merge Intervals
// ===============
//
// We are given an array of closed intervals called `intervals`, where each interval has a start time and an end
// time and is represented as `intervals[i] = [start_i, end_i]`. Your task is to merge the overlapping intervals
// and return a new output array consisting of only the non-overlapping intervals.
//
// Constraints:
//
// - 1 ≤ intervals.length ≤ 10^3
// - intervals[i].length == 2
// - 0 ≤ start_i ≤ end_i ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N05_MergeIntervals.P01_MergeIntervals;

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
