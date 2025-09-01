// Permutations II
// ===============
//
// For a given integer list, `nums`, which might contain duplicates, return all possible unique permutations derived
// from `nums`.
//
// > Note: The order in which the permutations appear doesn't matter.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 8
// - -10 ≤ `nums[i]` ≤ 10

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P25_PermutationsII;

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
