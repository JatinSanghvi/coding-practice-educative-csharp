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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P16_FindTheKSumOfAnArray;

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
