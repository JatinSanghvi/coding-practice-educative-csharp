// Contains Duplicate
// ==================
//
// For a given array of integers, `nums`, return TRUE if it contains duplicates. Otherwise, return FALSE.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^5
// - -10^9 ≤ `nums[i]` ≤ 10^9

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P05_ContainsDuplicate;

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
