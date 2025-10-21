// Divide Array Into Increasing Sequences
// ======================================
//
// Given a sorted integer array, `nums`, in non-decreasing order and an integer, `k`, determine whether it is possible
// to partition the array into one or more disjoint increasing subsequences, each having a length of at least `k`.
// Return `true` if such a partition exists; otherwise, return `false`.
//
// Constraints:
//
// - 1 ≤ `k` ≤ `nums.length` ≤ 10^3
// - 1 ≤ `nums[i]` ≤ 10^3
// - The `nums` array is sorted in non-decreasing order.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P14_DivideArrayIntoIncreasingSequences;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public bool CanDivideIntoSubsequences(int[] nums, int k)
    {
        int maxSets = nums.Length / k;
        int start = 0;
        for (int curr = 1; curr != nums.Length + 1; curr++)
        {
            if (curr == nums.Length || nums[curr] != nums[curr - 1])
            {
                int count = curr - start;
                if (count > maxSets) { return false; }
                start = curr;
            }
        }

        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(['1', '1', '1', '2', '2', '2', '3'], 3, false);
        Run(['1', '1', '1', '2', '2', '2', '3'], 2, true);
    }

    private static void Run(int[] nums, int k, bool expectedResult)
    {
        bool result = new Solution().CanDivideIntoSubsequences(nums, k);
        Utilities.PrintSolution((nums, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
