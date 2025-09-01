// Bulls and Cows
// ==============
//
// You are playing a number guessing game called "Bulls and Cows" with a friend.
//
// You write down a `secret` number, and your friend tries to `guess` it. After each `guess`, you provide a hint based
// on the following:
//
// - Bulls: The number of digits that are in the correct position in the `guess`.
// - Cows: The number of digits that are in both the `secret` and the `guess` but in different positions. (These are
//   non-bull digits that could become bulls if rearranged.)
//
// Your task is to return a hint for the `guess`, formatted as "xAyB", where:
//
// - x is the number of bulls.
// - y is the number of cows.
//
// > Note: Both the `secret` number and the `guess` may contain duplicate digits.
//
// Constraints:
//
// - 1 <= `secret.length`, `guess.length` ≤ 10^3
// - `secret.length` == `guess.length`
// - `secret` and `guess` consist of digits only.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P09_BullsAndCows;

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
