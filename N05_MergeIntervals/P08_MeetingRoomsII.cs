// Meeting Rooms II
// ================
//
// We are given an input array of meeting time intervals, `intervals`, where each interval has a start time and an end
// time. Your task is to find the minimum number of meeting rooms required to hold these meetings.
//
// > An important thing to note here is that the specified end time for each meeting is exclusive.
//
// Constraints:
//
// - 1 ≤ intervals.length ≤ 10^4
// - 0 ≤ start_i < end_i ≤ 10^6

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N05_MergeIntervals.P08_MeetingRoomsII;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(n).
    public static int FindSets(int[][] intervals)
    {
        (int time, bool isStart)[] events = intervals
            .SelectMany(interval => new[] { (interval[0], true), (interval[1], false) })
            .Order()
            .ToArray();

        int rooms = 0;
        int maxRooms = 0;
        foreach ((int time, bool isStart) in events)
        {
            if (!isStart)
            {
                rooms--;
            }
            else
            {
                rooms++;
                maxRooms = Math.Max(maxRooms, rooms);
            }
        }

        return maxRooms;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 3], [2, 4], [3, 5]], 2);
        Run([[1, 3], [2, 4], [3, 5], [1, 5], [2, 4]], 4);
    }

    private static void Run(int[][] intervals, int expectedResult)
    {
        int result = Solution.FindSets(intervals);
        Utilities.PrintSolution(intervals, result);
        Assert.AreEqual(expectedResult, result);
    }
}
