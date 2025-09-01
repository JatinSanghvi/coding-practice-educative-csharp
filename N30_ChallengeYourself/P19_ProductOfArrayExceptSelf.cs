// Product of Array Except Self
// ============================
//
// You're given an integer array, `arr`. Return a resultant array so that `res[i]` is equal to the product of all the
// elements of `arr` except `arr[i]`.
//
// Write an algorithm that runs in O(n) time without using the division operation.
//
// Constraints:
//
// - 2 ≤ `arr.length` ≤ 10^5
// - -30 ≤ `arr[i]` ≤ 30
// - The product of any prefix or suffix of `arr` is guaranteed to fit in a 32-bit integer.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P19_ProductOfArrayExceptSelf;

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
