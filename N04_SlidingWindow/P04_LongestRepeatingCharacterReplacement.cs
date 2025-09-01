// Longest Repeating Character Replacement
// =======================================
//
// Given a string, `s`, and an integer, `k`, find the length of the longest substring in `s`, where all characters
// are identical, after replacing, at most, `k` characters with any other uppercase English character.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 10^3
// - `s` consists of only uppercase English characters.
// - 0 ≤ `k` ≤ `s.length`

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P04_LongestRepeatingCharacterReplacement;

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
