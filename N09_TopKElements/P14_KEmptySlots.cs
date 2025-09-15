// K Empty Slots
// =============
//
// You are given n `bulbs` arranged in a row, numbered from 1 to n. Initially, all bulbs are turned off.
//
// Each day, exactly one bulb is switched on. You are given an array, `bulbs` of length n where `bulbs[i]` = x means
// that on day i + 1 (1‑indexed), the bulb at position x (also 1‑indexed) is turned on.
//
// So, given an integer `k`, determine the earliest day (the smallest day number) on which there are two bulbs that are
// on such that exactly `k` bulbs are off between them.
//
// If no such day exists, return -1.
//
// Constraints:
//
// - n == `bulbs.length`
// - 1 ≤ n ≤ 10^3
// - 1 ≤ `bulbs[i]` ≤ n
// - `bulbs` is a permutation of numbers from 1 to n
// - 0 ≤ k ≤ 10^3

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P14_KEmptySlots;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public int KEmptySlots(int[] bulbs, int k)
    {
        // Days when bulbs at different position was switched on.
        var days = new int[bulbs.Length];
        for (int i = 0; i < bulbs.Length; i++)
        {
            days[bulbs[i] - 1] = i + 1;
        }

        // Find two bulbs separated by distance k + 1, with 'days' greater than all bulbs in between. If there are
        // multiple such bulbs, select the ones with minimum 'days'.
        var betweenDays = new LinkedList<int>();
        int minCombinedDay = -1;

        for (int i = 0; i < days.Length; i++)
        {
            if (i >= k + 1)
            {
                if (days[i - (k + 1)] == betweenDays.First.Value)
                {
                    betweenDays.RemoveFirst();
                }

                int combinedDay = Math.Max(days[i], days[i - (k + 1)]);
                if (betweenDays.Count == 0 || combinedDay < betweenDays.First.Value)
                {
                    if (minCombinedDay == -1 || minCombinedDay > combinedDay)
                    {
                        minCombinedDay = combinedDay;
                    }
                }
            }

            while (betweenDays.Count != 0 && betweenDays.Last.Value > days[i])
            {
                betweenDays.RemoveLast();
            }

            betweenDays.AddLast(days[i]);
        }

        return minCombinedDay;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 5, 3, 7, 2, 6, 4, 8], 3, 2);
        Run([1, 5, 3, 7, 2, 6, 4, 8], 1, 3);
        Run([1, 5, 3, 7, 2, 6, 4, 8], 0, 5);
    }

    private static void Run(int[] bulbs, int k, int expectedResult)
    {
        int result = new Solution().KEmptySlots(bulbs, k);
        Utilities.PrintSolution((bulbs, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
