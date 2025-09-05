// Sliding Window Maximum
// ======================
//
// You are given an array of integers `nums` and a sliding window of size `w` that moves from left to right across the
// array, shifting one position at a time.
//
// Your task is to find the maximum value within the current window at each step and return it.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - -10^4 ≤ `nums[i]` ≤ 10^4
// - 1 ≤ `w` ≤ `nums.length`

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P02_SlidingWindowMaximum;

public class Solution
{
    public static int[] FindMaxSlidingWindow(int[] nums, int w)
    {
        var maximums = new int[nums.Length - w + 1];

        // Holds non-decreasing list of numbers in the window.
        var deque = new LinkedList<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (i >= w && deque.First.Value == nums[i - w])
            {
                deque.RemoveFirst();
            }

            while (deque.Count != 0 && deque.Last.Value < nums[i])
            {
                deque.RemoveLast();
            }

            deque.AddLast(nums[i]);

            if (i >= w - 1)
            {
                maximums[i - w + 1] = deque.First.Value;
            }
        }

        return maximums;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(new[] { 1, 2, 3, 2, 1, 2, 3, 2, 1 }, 1, new[] { 1, 2, 3, 2, 1, 2, 3, 2, 1 });
        Run(new[] { 1, 2, 3, 2, 1, 2, 3, 2, 1 }, 2, new[] { 2, 3, 3, 2, 2, 3, 3, 2 });
        Run(new[] { 1, 2, 3, 2, 1, 2, 3, 2, 1 }, 3, new[] { 3, 3, 3, 2, 3, 3, 3 });
        Run(new[] { 1, 2, 3, 2, 1, 2, 3, 2, 1 }, 9, new[] { 3 });
    }

    private static void Run(int[] nums, int w, int[] expectedResult)
    {
        int[] result = Solution.FindMaxSlidingWindow(nums, w);
        Utilities.PrintSolution((nums, w), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
