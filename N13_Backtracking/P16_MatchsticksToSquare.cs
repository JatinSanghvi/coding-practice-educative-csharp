// Matchsticks to Square
// =====================
//
// Given an integer array, `matchsticks`, where `matchsticks[i]` is the length of the i-th matchstick. Use every single
// matchstick to create a square. No stick should be broken, although they can be connected, and each matchstick can
// only be used once.
//
// Return TRUE if we can make this square; otherwise, return FALSE.
//
// Constraints:
//
// - 1 ≤ `matchsticks.length` ≤ 15
// - 1 ≤ `matchsticks[i]` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P16_MatchsticksToSquare;

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
