// Longest Subsequence With Limited Sum
// ====================================
//
// You are given an integer array, `nums`, of length `n`, and an integer array, `queries`, of length `m`.
//
// For each element in `queries`, determine the maximum number of elements that can be selected from `nums` to form a
// subsequence such that the sum of the selected elements is less than or equal to the query value.
//
// Return an array `answer` of length `m`, where `answer[i]` represents the size of the largest subsequence of `nums`
// whose sum is less than or equal to `queries[i]`.
//
// Constraints
//
// - n == `nums.length`
// - m == `queries.length`
// - 1 ≤ `n`, `m` ≤ 10^3
// - 1 ≤ `nums[i]`, `queries[i]` ≤ 10^5

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P02_LongestSubsequenceWithLimitedSum;

public class Solution
{
    // Time complexity: O((q+n)*logn), Space complexity: O(n).
    public static int[] AnswerQueries(int[] nums, int[] queries)
    {
        Array.Sort(nums);

        var sums = new int[nums.Length + 1];
        for (int i = 0; i != nums.Length; i++)
        {
            sums[i + 1] = sums[i] + nums[i];
        }

        var answer = new int[queries.Length];
        for (int i = 0; i != queries.Length; i++)
        {
            int low = 0, high = sums.Length;
            while (high - low != 1)
            {
                int mid = (low + high) / 2;
                if (sums[mid] <= queries[i]) { low = mid; }
                else { high = mid; }
            }

            answer[i] = low;
        }

        return answer;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([3, 2, 1, 1], [8, 7, 6, 5, 4, 3, 2, 1], [4, 4, 3, 3, 3, 2, 2, 1]);
    }

    private static void Run(int[] nums, int[] queries, int[] expectedResult)
    {
        int[] result = Solution.AnswerQueries(nums, queries);
        Utilities.PrintSolution((nums, queries), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
