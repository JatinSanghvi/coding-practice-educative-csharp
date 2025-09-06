// Frequency of the Most Frequent Element
// ======================================
//
// You are given an integer array, `nums`, and an integer `k`, representing the maximum number of operations you can
// perform. In each operation, you may select any index in `nums` and increment its value by 1.
//
// Your task is to determine the maximum possible frequency of a single element in the final array after performing at
// most `k` operations. You can choose to increase any elements in a way that results in one particular element
// appearing as often as possible (within `k` operations). For example, if `nums` = [2, 2, 3] and `k` = 4, you can
// increment the first and the second element, 2, once to match the third element, 3, achieving a maximum frequency
// of 3.
//
// Return the highest frequency that can be achieved for any element in `nums` after at most `k` operations.
//
// > The frequency of an element is the number of times it appears in an array.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - 1 ≤ `nums[i]` ≤ 10^3
// - 1 ≤ `k` ≤ 10^3

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P12_FrequencyOfTheMostFrequentElement;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(1).
    public static int MaxFrequency(int[] nums, int k)
    {
        Array.Sort(nums);

        int maxFrequency = 1;
        int additions = 0;

        int start = 0;
        for (int end = 1; end < nums.Length; end++)
        {
            additions += (nums[end] - nums[end - 1]) * (end - start); // Difference * Previous window size.

            while (additions > k)
            {
                additions -= nums[end] - nums[start];
                start++;
            }

            maxFrequency = Math.Max(maxFrequency, (end + 1) - start);
        }

        return maxFrequency;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(new int[] { 1, 3, 4, 3, 4, 3, 4 }, 2, 5);
        Run(new int[] { 1, 3, 4, 3, 4, 3, 4 }, 3, 6);
        Run(new int[] { 1, 3, 4, 3, 4, 3, 4 }, 5, 6);
        Run(new int[] { 1, 3, 4, 3, 4, 3, 4 }, 6, 7);
        Run(new int[] { 1, 3, 4, 3, 4, 3, 4 }, 7, 7);
    }

    private static void Run(int[] nums, int k, int expectedResult)
    {
        int result = Solution.MaxFrequency(nums, k);
        Utilities.PrintSolution((nums, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
