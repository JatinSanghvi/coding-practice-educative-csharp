// Find the K-Sum of an Array
// ==========================
//
// You are given an integer array, `nums`, and a positive integer `k`. Your task is to determine and return the kth
// largest possible sum among all subsequences of the array. A subsequence is formed by deleting no or more elements
// from the array without changing the order of the remaining elements. The sum of a subsequence is the total of its
// elements.
//
// > Remember: For valid subsequences:
//
// > - The empty subsequence is valid, and its sum is considered 0.
// > - Duplicate subsequence sums are allowed and counted separately when determining the kth largest.
//
// Constraints:
//
// - n == `nums.length`
// - 1 ≤ n ≤ 10^3
// - -10^3 ≤ `nums[i]` ≤ 10^3
// - 1 ≤ k ≤ min(1000, 2 n)

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P16_FindTheKSumOfAnArray;

public class Solution
{
    // Time complexity: O(n*logn+k*logk), Space complexity: O(k).
    public long KSum(int[] nums, int k)
    {
        // The largest number will be the sum of all positive integers. We then find k sets of numbers with smallest sum
        // that can be subtracted from the largest number's set. Note that excluding positive numbers and including
        // negative numbers have same effect. Hence, converting negative numbers to positive should simply the logic.
        int maxSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= 0)
            {
                maxSum += nums[i];
            }
            else
            {
                nums[i] = -nums[i];
            }
        }

        Array.Sort(nums);

        var setSums = new PriorityQueue<int, int>();
        setSums.Enqueue(0, 0);

        for (int j = 1; j < k; j++)
        {
            setSums.TryDequeue(out int i, out int sum);

            // Let's say we have an array (a,b,c) and we have generated all combinations with element i.e., (c), (ac), (bc)
            // and (abc). Now, element d joined the party and we need to generate new combinations made possible by d. There
            // are two set of such combinations:
            // - Combinations with 'c' retained with 'd' added: (cd), (acd), (bcd), (abcd).
            // - Combinations with 'c' removed and 'd' added: (d), (ad), (bd), (abd).
            if (i != nums.Length)
            {
                setSums.Enqueue(i + 1, sum + nums[i]);

                if (i != 0)
                {
                    setSums.Enqueue(i + 1, sum - nums[i - 1] + nums[i]);
                }
            }

            // There is more to why this strategy works, for example, if a,b,c,d are all equal, then we will dequeue
            // 'a', 'b', 'c', 'd' in sequence. If a,b,c,d are double of each other, then we will dequeue 'a', 'b', 'ab',
            // 'c', 'ac', etc. in sequence. Lots of magic!
        }

        setSums.TryPeek(out _, out int kthSum);
        return maxSum - kthSum;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([-5, 4, -3, 2, -1, 0], 1, 6);
        Run([-5, 4, -3, 2, -1, 0], 64, -9);
    }

    private static void Run(int[] nums, int k, int expectedResult)
    {
        int[] numsCopy = nums.ToArray();
        long result = new Solution().KSum(nums, k);
        Utilities.PrintSolution((numsCopy, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
