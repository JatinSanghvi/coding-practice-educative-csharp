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

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P05_MeetingRoomsIII;

public class Solution
{
    // Time complexity: O(m*(logm+logr)) where m=meetings, r=rooms, Space complexity: O(n).
    public static int MostBooked(int[][] meetings, int rooms)
    {
        var bookCounts = new int[rooms];
        var availableRooms = new PriorityQueue<int, int>();
        var bookedRooms = new PriorityQueue<(int end, int room), (int, int)>();

        for (int room = 0; room < rooms; room++)
        {
            availableRooms.Enqueue(room, room);
        }

        // Need not compare meetings by end time, since the start times are unique.
        Array.Sort(meetings, (m1, m2) => m1[0] - m2[0]);

        foreach (int[] meeting in meetings)
        {
            int meeting_start = meeting[0];
            int meeting_end = meeting[1];

            // Mark rooms as available if the meetings there have already ended.
            while (bookedRooms.Count != 0 && bookedRooms.Peek().end <= meeting_start)
            {
                int aRoom = bookedRooms.Dequeue().room;
                availableRooms.Enqueue(aRoom, aRoom);
            }

            // If there are still no rooms available, postpone the current meeting to the earliest availability time.
            if (availableRooms.Count == 0)
            {
                // Having room too added to the queue priority ensures that the room with lowest number gets picked first.
                (int end, int bRoom) = bookedRooms.Dequeue();
                availableRooms.Enqueue(bRoom, bRoom);
                int delay = end - meeting_start;
                meeting_start += delay;
                meeting_end += delay;
            }

            int room = availableRooms.Dequeue();
            bookCounts[room]++;
            bookedRooms.Enqueue((meeting_end, room), (meeting_end, room));
        }

        int maxRoom = -1;
        int maxBookedCount = 0;
        for (int room = 0; room < rooms; room++)
        {
            if (maxBookedCount < bookCounts[room])
            {
                maxBookedCount = bookCounts[room];
                maxRoom = room;
            }
        }
        return maxRoom;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 7], [2, 5], [3, 4], [4, 5]], 1, 0);
        Run([[1, 7], [2, 5], [3, 4], [4, 5]], 2, 1);
        Run([[1, 7], [2, 5], [3, 4], [4, 5]], 3, 2);
    }

    private static void Run(int[][] meetings, int rooms, int expectedResult)
    {
        int result = Solution.MostBooked(meetings, rooms);
        Utilities.PrintSolution((meetings, rooms), result);
        Assert.AreEqual(expectedResult, result);
    }
}
