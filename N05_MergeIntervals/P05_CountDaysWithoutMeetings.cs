// Count Days Without Meetings
// ===========================
//
// You are given a positive integer, `days`, which represents the total number of days an employee is available for
// work, starting from day 11. You are also given a 2D array, `meetings`, where each entry `meetings[i] = [start_i,
// end_i]` indicates that a meeting is scheduled from day `start_i` to day `end_i` (both inclusive).
//
// Your task is to count the days when the employee is available for work but has no scheduled meetings.
//
// > Note: The meetings may overlap.
//
// Constraints:
//
// - 1 ≤ days ≤ 10^5
// - 1 ≤ meetings.length ≤ 1000
// - meetings[i].length == 2
// - 1 ≤ meetings[i][0] ≤ meetings[i][1] ≤ days

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N05_MergeIntervals.P05_CountDaysWithoutMeetings;

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
