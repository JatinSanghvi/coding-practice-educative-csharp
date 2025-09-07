// Count Days Without Meetings
// ===========================
//
// You are given a positive integer, `days`, which represents the total number of days an employee is available for
// work, starting from day 1. You are also given a 2D array, `meetings`, where each entry `meetings[i] = [start_i,
// end_i]` indicates that a meeting is scheduled from day `start_i` to day `end_i` (both inclusive).
//
// Your task is to count the days when the employee is available for work but has no scheduled meetings.
//
// > Note: The meetings may overlap.
//
// Constraints:
//
// - 1 ≤ days ≤ 100,000
// - 1 ≤ meetings.length ≤ 1000
// - meetings[i].length == 2
// - 1 ≤ meetings[i][0] ≤ meetings[i][1] ≤ days

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N05_MergeIntervals.P05_CountDaysWithoutMeetings;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(1).
    public int CountDays(int days, int[][] meetings)
    {
        Array.Sort(meetings, (m1, m2) => m1[0] - m2[0]);

        int busyDays = 0;
        int busyStart = meetings[0][0], busyEnd = meetings[0][1];

        for (int i = 1; i < meetings.Length; i++)
        {
            if (meetings[i][0] <= busyEnd + 1)
            {
                busyEnd = Math.Max(busyEnd, meetings[i][1]);
            }
            else
            {
                busyDays += (busyEnd + 1) - busyStart;
                busyStart = meetings[i][0];
                busyEnd = meetings[i][1];
            }
        }

        busyDays += (busyEnd + 1) - busyStart;

        return days - busyDays;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(10, [[2, 3], [4, 5], [6, 9], [7, 8]], 2);
        Run(10, [[2, 3], [5, 6], [8, 9]], 4);
    }

    private static void Run(int days, int[][] meetings, int expectedResult)
    {
        int result = new Solution().CountDays(days, meetings);
        Utilities.PrintSolution((days, meetings), result);
        Assert.AreEqual(expectedResult, result);
    }
}
