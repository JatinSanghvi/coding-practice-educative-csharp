// Contains Duplicate II
// =====================
//
// You are given an integer array, `nums`, and an integer `k`. Determine whether two distinct indices, `i` and `j`,
// are in the array, such that `nums[i] == nums[j]` and the absolute difference between `i` and `j` is at most `k`.
// Return TRUE if such indices exist; otherwise, return FALSE.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - -10^3 ≤ `nums[i]` ≤ 10^3
// - 0 ≤ `k` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P11_ContainsDuplicateII;

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
