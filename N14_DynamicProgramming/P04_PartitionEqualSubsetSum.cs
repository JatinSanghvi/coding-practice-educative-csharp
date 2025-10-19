// Partition Equal Subset Sum
// ==========================
//
// Given a non-empty array of positive integers, determine if the array can be divided into two subsets so that the sum
// of both subsets is equal.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 200
// - 1 ≤ `nums[i]` ≤ 100

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P04_PartitionEqualSubsetSum;

public class Solution
{
    // Time complexity: O(n*s), Space complexity: O(s) where s = sum(arr).
    public static bool CanPartitionArray(int[] arr)
    {
        int total = arr.Sum();
        if (total % 2 != 0) { return false; }

        var sums = new bool[total / 2 + 1];
        sums[0] = true;

        foreach (int num in arr)
        {
            for (int i = total / 2; i >= num; i--)
            {
                sums[i] = sums[i] || sums[i - num];
            }
        }

        return sums[total / 2];
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([4, 3, 2, 1], true);
        Run([1, 2, 3, 6], true);
        Run([2, 2, 4, 6], false);
    }

    private static void Run(int[] arr, bool expectedResult)
    {
        bool result = Solution.CanPartitionArray(arr);
        Utilities.PrintSolution(arr, result);
        Assert.AreEqual(expectedResult, result);
    }
}
