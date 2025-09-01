// Longest Increasing Subsequence
// ==============================
//
// The Longest Increasing Subsequence (LIS) is the longest subsequence from a given array in which the subsequence
// elements are sorted in a strictly increasing order. Given an integer array, `nums`, find the length of the LIS in
// this array.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 1000
// - -10^4 ≤ `nums[i]` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P20_LongestIncreasingSubsequence;

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
