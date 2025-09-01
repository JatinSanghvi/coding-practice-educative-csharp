// Maximum Subarray
// ================
//
// Given an integer array, `nums`, find the contiguous subarray that has the largest sum and return its sum.
//
// > Note: A subarray is a contiguous part of an array that contains at least one number.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^5
// - -10^4 ≤ `nums[i]` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P06_MaximumSubarray;

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
