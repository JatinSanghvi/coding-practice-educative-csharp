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

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P10_MeetingRooms;

public class Solution
{
    // Time complexity: O(n logn), Space complexity: O(1).
    public static bool CanAttendMeetings(int[][] intervals)
    {
        Array.Sort(intervals, (i1, i2) => i1[0] - i2[0]);
        
        for (int i = 0; i < intervals.Length - 1; i++)
        {
            if (intervals[i][1] > intervals[i + 1][0])
            {
                return false;
            }
        }

        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 2], [3, 4], [2, 3]], true);
        Run([[1, 2], [2, 5], [3, 4]], false);
    }

    private static void Run(int[][] intervals, bool expectedResult)
    {
        bool result = Solution.CanAttendMeetings(intervals);
        Utilities.PrintSolution(intervals, result);
        Assert.AreEqual(expectedResult, result);
    }
}
