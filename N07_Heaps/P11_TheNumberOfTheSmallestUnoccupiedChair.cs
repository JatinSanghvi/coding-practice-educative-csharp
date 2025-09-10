// The Number of the Smallest Unoccupied Chair
// ===========================================
//
// At a party, n friends, numbered from 0 to n - 1, arrive and leave at different times. There are infinitely many chairs,
// numbered 0 onwards. Each arriving friend sits on the smallest available chair at that moment.
//
// For example, if chairs 0, 1, and 5 are occupied when a friend arrives, they will sit on chair number 2.
//
// When a friend leaves, their chair becomes immediately available. If another friend arrives simultaneously, they can
// take that chair.
//
// You are given a 0-indexed 2D list `times`, where `times[i] = [arrival_i, leaving_i]` represents the arrival and
// departure times of the ith friend. All arrival times are unique.
//
// Given an integer `target_friend`, return the chair number that `target_friend` will sit on.
//
// Constraints:
//
// - n == `times.length`
// - `times[i].length` == 2
// - 1 ≤ `arrival_i` < `leaving_i` ≤ 10^5
// - 0 ≤ `target_friend` ≤ n - 1
// - Each `arrival_i` time is unique.

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P11_TheNumberOfTheSmallestUnoccupiedChair;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(n).
    public static int SmallestChair(int[][] times, int targetFriend)
    {
        var freeChairs = new PriorityQueue<int, int>();
        var occupiedChairs = new PriorityQueue<(int number, int endTime), int>();

        var friends = new (int index, int startTime, int endTime)[times.Length];
        for (int i = 0; i < times.Length; i++)
        {
            friends[i] = (i, times[i][0], times[i][1]);
        }

        Array.Sort(friends, (f1, f2) => f1.startTime - f2.startTime);

        foreach (var friend in friends)
        {
            while (occupiedChairs.Count != 0 && occupiedChairs.Peek().endTime <= friend.startTime)
            {
                int number = occupiedChairs.Dequeue().number;
                freeChairs.Enqueue(number, number);
            }

            if (freeChairs.Count == 0)
            {
                int number = occupiedChairs.Count;
                freeChairs.Enqueue(number, number);
            }

            int smallestNumber = freeChairs.Dequeue();
            if (friend.index == targetFriend)
            {
                return smallestNumber;
            }

            occupiedChairs.Enqueue((smallestNumber, friend.endTime), friend.endTime);
        }

        return -1;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[5, 6], [4, 5], [3, 4], [2, 6], [1, 7]], 1, 2);
    }

    private static void Run(int[][] times, int targetFriend, int expectedResult)
    {
        int result = Solution.SmallestChair(times, targetFriend);
        Utilities.PrintSolution((times, targetFriend), result);
        Assert.AreEqual(expectedResult, result);
    }
}
