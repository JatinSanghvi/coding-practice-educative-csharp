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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P04_PartitionEqualSubsetSum;

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
