// Subarrays with K Different Integers
// ===================================
//
// You are given an integer array `nums` and an integer `k`. Your task is to return the number of good subarrays of
// `nums`.
//
// > A good subarray is a contiguous subarray that contains exactly k distinct integers. For example, in the array
// [1,2,3,1,2], the subarray [1,2,3] contains 3 distinct integers: 1, 2, and 3.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 2∗10^4
// - 1 ≤ `nums[i]`, `k` ≤ `nums.length`

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P13_SubarraysWithKDifferentIntegers;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public int SubarraysWithKDistinct(int[] nums, int k)
    {
        // It is easier to find number of subarrays with "maximum" k distinct characters.
        // Subarrays with "exactly" k chars = subarrays with max k chars - subarrays with max k-1 chars.
        return SubarraysWithKMax(k) - SubarraysWithKMax(k - 1);

        int SubarraysWithKMax(int k)
        {
            int subarrays = 0;

            var numCounts = new Dictionary<int, int>();
            int distincts = 0;

            int start = 0;
            for (int end = 0; end < nums.Length; end++)
            {
                int end_num = nums[end];
                numCounts.TryAdd(end_num, 0);
                numCounts[end_num]++;

                if (numCounts[end_num] == 1) // Distinct numbers increased.
                {
                    distincts += 1;

                    if (distincts == k + 1)
                    {
                        while (true)
                        {
                            int start_num = nums[start];
                            numCounts[start_num]--;
                            start++;

                            if (numCounts[start_num] == 0) // Distinct numbers reduced.
                            {
                                distincts = k;
                                break;
                            }
                        }
                    }
                }

                // Subarrays nums[start..(end+1)] .. nums[end..(end+1)] contain at most k distinct elements.
                subarrays += (end + 1) - start;
            }

            return subarrays;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(new int[] { 1, 2, 3, 1, 2, 3 }, 2, 5);
        Run(new int[] { 1, 2, 3, 1, 2, 3 }, 3, 10);
    }

    private static void Run(int[] nums, int k, int expectedResult)
    {
        int result = new Solution().SubarraysWithKDistinct(nums, k);
        Utilities.PrintSolution((nums, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
