// Meeting Rooms III
// =================
//
// Given an integer, `rooms`, which represents the total number of rooms, where each room is numbered from `0` to
// `rooms - 1`. Additionally, you are given a 2D integer array called `meetings`, where each element
// `meetings[i] = [start_i, end_i]` indicates that a meeting will be held in the half-closed interval [start_i, end_i).
// Each start_i is unique.
//
// Meetings are allocated to rooms in the following manner:
//
// 1. Each meeting will take place in the unused room with the lowest number.
// 2. If there are no available rooms, the meeting will be delayed until a room becomes free. The delayed meeting should
//    have the same duration as the original meeting.
// 3. When a room is vacated, the meeting with the earliest original start time is given priority for that room.
//
// Your task is to determine the room number that hosted the most meetings. If there are multiple rooms, return the room
// with the lowest number.
//
// Note: A half-closed interval [a, b) is the interval between a and b, including a and not including b.
//
// Constraints:
//
// - 1 ≤ `rooms` ≤ 100
// - 1 ≤ `meetings.length` ≤ 1000
// - `meetings[i].length` == 2
// - 0 ≤ start_i < end_i ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P05_MeetingRoomsIII;

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
