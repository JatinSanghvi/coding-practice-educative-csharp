// Contains Duplicate II
// =====================
//
// You are given an integer array, `nums`, and an integer `k`. Determine whether two distinct indices, `i` and `j`, are
// in the array, such that `nums[i] == nums[j]` and the absolute difference between `i` and `j` is at most `k`. Return
// TRUE if such indices exist; otherwise, return FALSE.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - -10^3 ≤ `nums[i]` ≤ 10^3
// - 0 ≤ `k` ≤ 10^4

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P11_ContainsDuplicateII;

public class Solution
{
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var numSet = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > k)
            {
                numSet.Remove(nums[i - (k + 1)]);
            }

            if (numSet.Contains(nums[i]))
            {
                return true;
            }

            numSet.Add(nums[i]);
        }

        return false;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(new int[] { 1, 1, 1, 1 }, 0, false);
        Run(new int[] { 1, 2, 3, 1 }, 2, false);
        Run(new int[] { 1, 2, 3, 1 }, 3, true);
        Run(new int[] { 1, 1, 2, 3 }, 3, true);
    }

    private static void Run(int[] nums, int k, bool expectedResult)
    {
        bool result = Solution.ContainsNearbyDuplicate(nums, k);
        Utilities.PrintSolution((nums, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
