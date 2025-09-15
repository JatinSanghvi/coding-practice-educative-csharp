// Find Subsequence of Length K with the Largest Sum
// =================================================
//
// You are given an integer array `nums` and an integer `k`. Your task is to find a subsequence of `nums` of length `k`
// that has the largest possible sum.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 1000
// - -10^5 ≤ `nums[i]` ≤ 10^5
// - 1 ≤ k ≤ `nums.length`

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P07_FindSubsequenceOfLengthKWithTheLargestSum;

public class Solution
{
    // Time complexity: O(n*logk), Space complexity: O(k).
    public static int[] MaxSubsequence(int[] nums, int k)
    {
        var numsQueue = new PriorityQueue<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            numsQueue.Enqueue(i, nums[i]);
            if (numsQueue.Count > k)
            {
                numsQueue.Dequeue();
            }
        }

        return numsQueue.UnorderedItems
            .Select(items => items.Element)
            .Order()
            .Select(index => nums[index])
            .ToArray();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 4, 4, 3, 2, 1], 5, [3, 4, 4, 3, 2]);
    }

    private static void Run(int[] nums, int k, int[] expectedResult)
    {
        int[] result = Solution.MaxSubsequence(nums, k);
        Utilities.PrintSolution((nums, k), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
