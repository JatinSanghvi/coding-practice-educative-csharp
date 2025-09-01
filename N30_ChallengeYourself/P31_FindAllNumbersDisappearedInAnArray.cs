// Find All Numbers Disappeared in an Array
// ========================================
//
// Given an array, `nums`, of n integers where `nums[i]` is in the range [1,n], return an array of all the integers in
// the range [1,n] that doesn't appear in `nums`.
//
// Constraints:
//
// - n= `nums.length`
//
// - 1≤n≤103
//
// - 1≤ `nums[i]` ≤n

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P31_FindAllNumbersDisappearedInAnArray;

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
