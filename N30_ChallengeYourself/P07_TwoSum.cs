// Two Sum
// =======
//
// For the given array of integers `arr` and a target `t`, you have to identify the two indices that add up to generate
// the target `t`. Moreover, you can't use the same index twice, and there will be only one solution.
//
// > Note: We will assume that the array is zero-indexed and the output order doesn't matter.
//
// Constraints:
//
// - 2 ≤ `arr.length` ≤ 10^4
// - -10^9 ≤ `arr[i]` ≤ 10^9
// - -10^9 ≤ `t` ≤ 10^9
// - Only one valid answer exists.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P07_TwoSum;

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
