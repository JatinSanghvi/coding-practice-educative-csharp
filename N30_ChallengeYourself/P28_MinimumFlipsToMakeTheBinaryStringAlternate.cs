// Minimum Flips to Make the Binary String Alternate
// =================================================
//
// Given a binary string `s`, the following two operations can be performed in any sequence:
//
// - Type--1: Remove the character at the start of the string `s` and append it to the end of the string.
//
// - Type--2: Pick any character from the string and flip its value. in other words, if its value is 0, it becomes 1 and
//   vice versa.
//
// Your task is to return the minimum number of type-2 operations that you need to perform before `s` becomes
// alternating.
//
// > Note: The string is called alternating if no two adjacent characters are equal.
//
// Constraints:
//
// - 1≤ `s.length` ≤105
// - `s[i]` is either 0 or 1.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P28_MinimumFlipsToMakeTheBinaryStringAlternate;

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
