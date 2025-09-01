// Meeting Rooms
// =============
//
// You are given an array of meeting times, `intervals`, where each interval consists of a pair of start and end times,
// identify whether or not a person can attend all the meetings.
//
// > An important thing to note here is that the specified end time for each meeting is exclusive.
//
// Constraints:
//
// - 0 ≤ `intervals.length` ≤ 10^4
// - `intervals[i].length` == 2
// - 0 ≤ start_i < end_i ≤ 10^6

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P10_MeetingRooms;

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
