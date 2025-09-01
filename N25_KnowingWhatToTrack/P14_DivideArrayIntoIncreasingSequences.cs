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
    public static bool Function()
    {
        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(true);
    }

    private static void Run(bool expectedResult)
    {
        bool result = Solution.Function();
        Utilities.PrintSolution(true, result);
        Assert.AreEqual(expectedResult, result);
    }
}
