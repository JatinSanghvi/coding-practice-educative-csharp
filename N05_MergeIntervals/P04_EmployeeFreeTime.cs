// Employee Free Time
// ==================
//
// You're given a list containing the schedules of multiple employees. Each person's schedule is a list of
// non-overlapping intervals in sorted order. An interval is specified with the start and end time, both being
// positive integers. Your task is to find the list of finite intervals representing the free time for all the
// employees.
//
// > Note: The common free intervals are calculated between the earliest start time and the latest end time of all
// meetings across all employees.
//
// Constraints:
//
// - 1 ≤ schedule.length, schedule[i].length ≤ 50
// - 0 ≤ interval.start < interval.end ≤ 10^8, where `interval` is any interval in the list of schedules.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N05_MergeIntervals.P04_EmployeeFreeTime;

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
