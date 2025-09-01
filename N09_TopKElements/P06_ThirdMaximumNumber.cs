// Third Maximum Number
// ====================
//
// For a given integer array `nums`, your task is to return the third maximum distinct number in the array. If there are
// fewer than three distinct numbers, return the maximum number.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - -2^31 ≤ `nums[i]` ≤ 2^31 - 1

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P06_ThirdMaximumNumber;

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
