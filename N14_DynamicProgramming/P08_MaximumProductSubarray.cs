// Maximum Product Subarray
// ========================
//
// Given an integer array, `nums`, find a subarray that has the largest product, and return the product.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - -10 ≤ `nums[i]` ≤ 10
// - The product of any prefix or suffix of `nums` is guaranteed to fit in a 32-bit integer.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P08_MaximumProductSubarray;

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
