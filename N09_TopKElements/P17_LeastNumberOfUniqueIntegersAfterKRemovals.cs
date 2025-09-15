// Least Number of Unique Integers after K Removals
// ================================================
//
// You are given an integer array, `arr`, and an integer, `k`. Your task is to remove exactly `k` elements from the
// array so that the number of distinct integers remaining in the array is minimized. Determine the minimum possible
// count of unique integers after the removals.
//
// Constraints:
//
// - 1 ≤ `arr.length` ≤ 10^3
// - 1 ≤ `arr[i]` ≤ 10^5
// - 0 ≤ k ≤ `arr.length`

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P17_LeastNumberOfUniqueIntegersAfterKRemovals;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(n).
    public int FindLeastNumOfUniqueInts(int[] arr, int k)
    {
        var numCounts = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            numCounts.TryAdd(num, 0);
            numCounts[num]++;
        }

        int[] counts = numCounts.Select(pair => pair.Value).Order().ToArray();

        int i;
        for (i = 0; i < counts.Length; i++)
        {
            if (k < counts[i]) { break; }
            k -= counts[i];
        }

        return counts.Length - i;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 4, 4], 0, 4);
        Run([1, 2, 3, 4, 4], 2, 2);
        Run([1, 2, 3, 4, 4], 4, 1);
        Run([1, 2, 3, 4, 4], 5, 0);
    }

    private static void Run(int[] nums, int k, int expectedResult)
    {
        int result = new Solution().FindLeastNumOfUniqueInts(nums, k);
        Utilities.PrintSolution((nums, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
