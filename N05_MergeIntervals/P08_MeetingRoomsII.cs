// Meeting Rooms II
// ================
//
// We are given an input array of meeting time intervals, `intervals`, where each interval has a start time and an
// end time. Your task is to find the minimum number of meeting rooms required to hold these meetings.
//
// > An important thing to note here is that the specified end time for each meeting is exclusive.
//
// Constraints:
//
// - 1 ≤ intervals.length ≤ 10^4
// - 0 ≤ start_i < end_i ≤ 10^6

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N05_MergeIntervals.P08_MeetingRoomsII;

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
