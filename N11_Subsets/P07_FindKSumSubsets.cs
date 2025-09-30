// Find K-Sum Subsets
// ==================
//
// Given an array of n distinct positive integers, find all possible subsets of these integers such that the sum of the
// elements in each subset equals a given target value `k`.
//
// Return a 2D array, where each inner array represents a subset whose sum equals `k`.
//
// Constraints:
//
// - 1 ≤ n ≤ 10
// - 1 ≤ x ≤ 100, where x is any member of the input array.
// - 1 ≤ `k` ≤ 10^3

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N11_Subsets.P07_FindKSumSubsets;

public class Solution
{
    // Time complexity: O(2^n), Space complexity: O(n).
    public static List<List<int>> GetKSumSubsets(int[] nums, int k)
    {
        var subsets = new List<List<int>>();
        var subset = new int[nums.Length];
        Solve(0, 0, 0);
        return subsets;

        void Solve(int numsIndex, int subsetIndex, int sum)
        {
            if (sum > k) { return; }

            if (sum == k)
            {
                subsets.Add(new List<int>(subset[..subsetIndex]));
                return;
            }

            if (numsIndex == nums.Length) { return; }

            subset[subsetIndex] = nums[numsIndex];
            Solve(numsIndex + 1, subsetIndex + 1, sum + nums[numsIndex]); // With number.
            Solve(numsIndex + 1, subsetIndex, sum); // Without number.
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 4, 5], 10, [[1, 2, 3, 4], [1, 4, 5], [2, 3, 5]]);
    }

    private static void Run(int[] nums, int k, int[][] expectedResult)
    {
        int[][] result = Solution.GetKSumSubsets(nums, k)
            .Select(subset => subset.ToArray())
            .ToArray();

        Utilities.PrintSolution((nums, k), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
